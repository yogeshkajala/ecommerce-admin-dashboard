using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Polly;
using Polly.Retry;
using EcommerceAdmin.Infrastructure.Data;

namespace EcommerceAdmin.Infrastructure.Messaging;

public record ProductPriceChangedIntegrationEvent(int ProductId, decimal NewPrice, decimal OldPrice);

public class EventBusBackgroundService : BackgroundService
{
    private readonly ILogger<EventBusBackgroundService> _logger;
    private readonly IServiceProvider _serviceProvider;
    private IConnection? _connection;
    private IModel? _channel;
    
    private const string ExchangeName = "eshop_event_bus";
    private const string QueueName = "admin_dashboard_events";
    private const string DeadLetterExchangeName = "eshop_event_bus_dlx";
    private const string DeadLetterQueueName = "admin_dashboard_events_dlq";

    public EventBusBackgroundService(
        ILogger<EventBusBackgroundService> logger,
        IServiceProvider serviceProvider)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
        InitializeRabbitMQ();
    }

    private void InitializeRabbitMQ()
    {
        var factory = new ConnectionFactory { HostName = "localhost" }; // Assuming local for development

        try
        {
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();

            _channel.ExchangeDeclare(exchange: ExchangeName, type: ExchangeType.Direct);
            _channel.ExchangeDeclare(exchange: DeadLetterExchangeName, type: ExchangeType.Direct);

            _channel.QueueDeclare(queue: DeadLetterQueueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
            _channel.QueueBind(queue: DeadLetterQueueName, exchange: DeadLetterExchangeName, routingKey: "");

            var queueArgs = new Dictionary<string, object>
            {
                { "x-dead-letter-exchange", DeadLetterExchangeName }
            };

            _channel.QueueDeclare(queue: QueueName, durable: true, exclusive: false, autoDelete: false, arguments: queueArgs);
            _channel.QueueBind(queue: QueueName, exchange: ExchangeName, routingKey: nameof(ProductPriceChangedIntegrationEvent));

            _channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to initialize RabbitMQ connection.");
        }
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (_channel == null) return Task.CompletedTask;

        stoppingToken.ThrowIfCancellationRequested();

        var consumer = new EventingBasicConsumer(_channel);
        consumer.Received += async (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            var routingKey = ea.RoutingKey;

            try
            {
                if (routingKey == nameof(ProductPriceChangedIntegrationEvent))
                {
                    var integrationEvent = JsonSerializer.Deserialize<ProductPriceChangedIntegrationEvent>(message);
                    if (integrationEvent != null)
                    {
                        await ProcessEventWithRetryAsync(integrationEvent, stoppingToken);
                    }
                }

                _channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing message, nacking and routing to DLQ.");
                _channel.BasicNack(deliveryTag: ea.DeliveryTag, multiple: false, requeue: false);
            }
        };

        _channel.BasicConsume(queue: QueueName, autoAck: false, consumer: consumer);

        return Task.CompletedTask;
    }

    private async Task ProcessEventWithRetryAsync(ProductPriceChangedIntegrationEvent integrationEvent, CancellationToken stoppingToken)
    {
        var retryPolicy = Policy
            .Handle<Exception>()
            .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
                (exception, timeSpan, retryCount, context) =>
                {
                    _logger.LogWarning(exception, "Error processing event {EventId}. Retrying {RetryCount} in {Delay}s.", integrationEvent.ProductId, retryCount, timeSpan.TotalSeconds);
                });

        await retryPolicy.ExecuteAsync(async () =>
        {
            using var scope = _serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<CatalogDbContext>();
            
            // Simulate processing the event using CatalogDbContext
            _logger.LogInformation("Processing ProductPriceChangedIntegrationEvent for ProductId: {ProductId}, NewPrice: {NewPrice}", integrationEvent.ProductId, integrationEvent.NewPrice);
            
            // For example purposes, we just log that we would interact with dbContext here
            // var item = await dbContext.CatalogItems.FindAsync(new object[] { integrationEvent.ProductId }, stoppingToken);
            // if (item != null) { item.Price = integrationEvent.NewPrice; await dbContext.SaveChangesAsync(stoppingToken); }

            await Task.Yield();
        });
    }

    public override void Dispose()
    {
        if (_channel != null && _channel.IsOpen)
        {
            _channel.Close();
            _channel.Dispose();
        }

        if (_connection != null && _connection.IsOpen)
        {
            _connection.Close();
            _connection.Dispose();
        }

        base.Dispose();
    }
}