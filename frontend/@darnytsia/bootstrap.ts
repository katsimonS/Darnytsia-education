import {} from '@edenlabllc/sdk/extensions/handler-chain-service-extensions';
import { configureLocalization } from '@edenlabllc/sdk/lcz';
import { registerHooks } from '@edenlabllc/sdk/register-hooks';
import {} from '@edenlabllc/sdk/ui/7x-extensions';

export const configure = (): void => {
  configureLocalization();

  registerHooks('Darnytsia.Creatio');
};
