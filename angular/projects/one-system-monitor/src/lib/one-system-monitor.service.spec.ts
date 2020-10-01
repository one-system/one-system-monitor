import { TestBed } from '@angular/core/testing';

import { OneSystemMonitorService } from './one-system-monitor.service';

describe('OneSystemMonitorService', () => {
  let service: OneSystemMonitorService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OneSystemMonitorService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
