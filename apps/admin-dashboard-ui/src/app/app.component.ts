import { Component } from '@angular/core';
import { DashboardComponent } from './components/dashboard/dashboard.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [DashboardComponent],
  template: `
    <h1>E-Commerce Admin Dashboard</h1>
    <app-dashboard></app-dashboard>
  `,
})
export class AppComponent {
  title = 'admin-dashboard-ui';
}