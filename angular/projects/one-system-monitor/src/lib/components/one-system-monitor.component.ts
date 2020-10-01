import { Component, OnInit } from '@angular/core';
import { OneSystemMonitorService } from '../services/one-system-monitor.service';

@Component({
  selector: 'lib-one-system-monitor',
  template: ` <p>one-system-monitor works!</p> `,
  styles: [],
})
export class OneSystemMonitorComponent implements OnInit {
  constructor(private service: OneSystemMonitorService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
