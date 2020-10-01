import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { OneSystemMonitorComponent } from './components/one-system-monitor.component';
import { OneSystemMonitorRoutingModule } from './one-system-monitor-routing.module';

@NgModule({
  declarations: [OneSystemMonitorComponent],
  imports: [CoreModule, ThemeSharedModule, OneSystemMonitorRoutingModule],
  exports: [OneSystemMonitorComponent],
})
export class OneSystemMonitorModule {
  static forChild(): ModuleWithProviders<OneSystemMonitorModule> {
    return {
      ngModule: OneSystemMonitorModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<OneSystemMonitorModule> {
    return new LazyModuleFactory(OneSystemMonitorModule.forChild());
  }
}
