import { ModuleWithProviders, NgModule } from '@angular/core';
import { ONE_SYSTEM_MONITOR_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class OneSystemMonitorConfigModule {
  static forRoot(): ModuleWithProviders<OneSystemMonitorConfigModule> {
    return {
      ngModule: OneSystemMonitorConfigModule,
      providers: [ONE_SYSTEM_MONITOR_ROUTE_PROVIDERS],
    };
  }
}
