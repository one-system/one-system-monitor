import { Config } from '@abp/ng.core';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'OneSystemMonitor',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44360',
    clientId: 'OneSystemMonitor_ConsoleTestApp',
    dummyClientSecret: '1q2w3e*',
    scope: 'OneSystemMonitor',
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44360',
      rootNamespace: 'OneSystemMonitor',
    },
    OneSystemMonitor: {
      url: 'https://localhost:44310',
      rootNamespace: 'OneSystemMonitor',
    },
  },
} as Config.Environment;
