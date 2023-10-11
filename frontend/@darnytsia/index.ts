import { configure } from './bootstrap';
import { useLcz } from '@edenlabllc/sdk/hooks';
import { constants } from './db/consts';
var a =1;
export = {
  configure,
  db: {
    const: constants
  },
  lcz: useLcz,
  ui: {
    pages: {},
    details: {},
    sections: {}
  }
};
