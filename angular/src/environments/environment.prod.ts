import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'project_management',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44328',
    redirectUri: baseUrl,
    clientId: 'project_management_App',
    responseType: 'code',
    scope: 'offline_access project_management',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44328',
      rootNamespace: 'lcn.project_management',
    },
  },
} as Environment;
