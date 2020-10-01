import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OneSystemMonitorComponent } from './one-system-monitor.component';

describe('OneSystemMonitorComponent', () => {
  let component: OneSystemMonitorComponent;
  let fixture: ComponentFixture<OneSystemMonitorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OneSystemMonitorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OneSystemMonitorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
