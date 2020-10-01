import { Config } from '@abp/ng.core';

export const environment = {
  production: true,
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
    },
    OneSystemMonitor: {
      url: 'https://localhost:44310',
    },
  },
} as Config.Environment;
