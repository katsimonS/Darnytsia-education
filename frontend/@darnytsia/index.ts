import { configure } from './bootstrap';
import { useLcz } from '@edenlabllc/sdk/hooks';
import { constants } from './db/consts';
import {EdlBook_FormPage} from "./ui/pages/book-form-page";
var a =1;
export = {
  configure,
  db: {
    const: constants
  },
  lcz: useLcz,
  ui: {
    pages: {
        EdlBook_FormPage: EdlBook_FormPage
    },
    details: {},
    sections: {}
  }
};
