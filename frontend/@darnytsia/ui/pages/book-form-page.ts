import { FreedomUIHandler } from '@edenlabllc/sdk/ui/freedom-ui';
import { useInit, useEffect, useState } from '@edenlabllc/sdk/hooks';
import { CURRENT_USER } from '@edenlabllc/sdk/users';
import { constants } from '../../db/consts';
import { LookupValue } from '@creatio-devkit/common';

export const EdlBook_FormPage = (): Array<FreedomUIHandler> => {
  const [, setIsEdlNameReadOnly] = useState<boolean>('IsEdlNameReadOnly');
  const [status] = useState<LookupValue>('LookupAttribute_m4r9pkj');

  useInit(() => {
    setFieldReadOnly();
  });

  useEffect(async() => {
    await setFieldReadOnly();
  });
  const setFieldReadOnly = (): void => {
    if (CURRENT_USER.roles.includes(constants.SYS_ADMIN_UNIT.SYSTEM_ADMINISTRATORS) ||
        status().value === constants.Book.Stage.Planned) {
      setIsEdlNameReadOnly(false);
    } else {
      setIsEdlNameReadOnly(true);
    }
  };

  return [];
};
