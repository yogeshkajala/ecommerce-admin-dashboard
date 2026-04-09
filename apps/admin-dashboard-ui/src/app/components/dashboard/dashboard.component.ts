import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SignalRService } from '../../services/signalr.service';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [CommonModule],
  template: `
    <div>
      <h2>Real-time Events</h2>
      <ul>
        <li *ngFor="let event of events">
          Product Price Changed: {{ event | json }}
        </li>
      </ul>
      <p *ngIf="events.length === 0">No events yet.</p>
    </div>
  `,
  styles: [`
    ul { list-style-type: none; padding: 0; }
    li { background: #f4f4f4; margin: 5px 0; padding: 10px; border-radius: 4px; }
  `]
})
export class DashboardComponent implements OnInit {
  events: any[] = [];

  constructor(private signalRService: SignalRService) {}

  ngOnInit(): void {
    this.signalRService.startConnection();
    this.signalRService.addProductPriceChangedListener();

    this.signalRService.productPriceChanged$.subscribe((data: any) => {
      this.events.push(data);
    });
  }
}