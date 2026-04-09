import { Injectable } from '@angular/core';
import * as signalR from '@microsoft/signalr';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SignalRService {
  private hubConnection: signalR.HubConnection | undefined;
  public productPriceChanged$ = new Subject<any>();

  constructor() { }

  public startConnection = () => {
    this.hubConnection = new signalR.HubConnectionBuilder()
                            .withUrl('http://localhost:5000/hub/events')
                            .withAutomaticReconnect()
                            .build();

    this.hubConnection
      .start()
      .then(() => console.log('SignalR Connection started'))
      .catch(err => console.log('Error while starting connection: ' + err));
  }

  public addProductPriceChangedListener = () => {
    this.hubConnection?.on('ProductPriceChanged', (data) => {
      this.productPriceChanged$.next(data);
    });
  }
}