import { FreedomUIHandler,
  createCompareFilter,
  createFilterGroup,
  createExistsFilter,
  createInFilter,
  LoadDataRequest,
  DataGridCreateItemRequest } from '@edenlabllc/sdk/ui/freedom-ui';
import { useInit, useEffect, useState } from '@edenlabllc/sdk/hooks';
import { CURRENT_USER } from '@edenlabllc/sdk/users';
import { constants } from '../../db/consts';
import { ComparisonType, DataValueType, LookupValue } from '@creatio-devkit/common';

export const EdlBook_FormPage = (): Array<FreedomUIHandler> => {
  const [, setIsEdlNameReadOnly] = useState<boolean>('IsEdlNameReadOnly');
  const [status] = useState<LookupValue>('LookupAttribute_m4r9pkj');
  const [authorList] = useState<any>('GridDetail_l8d938f');

  useInit(() => {
    setFieldReadOnly();
  });

  useEffect(async() => {
    await setFieldReadOnly();
  });

  const loadAuthorList = (): void => {
    const listData = authorList();
    listData?.forEach(data => {
      data.GridDetail_l8d938fDS_EdlAuthor_List_BusinessRule_Filter = createFilterGroup({
        ContactsFilter: createCompareFilter(
          ComparisonType.Equal,
          'Type',
          constants.CONTACT.TYPE.EMPLOYEE,
          DataValueType.Lookup)
      });
      data.formApiModel.controls.GridDetail_l8d938fDS_EdlAuthor_List_BusinessRule_Filter.disable();
    });
  };

  const setFieldReadOnly = (): void => {
    if (CURRENT_USER.roles.includes(constants.SYS_ADMIN_UNIT.SYSTEM_ADMINISTRATORS) ||
        status().value === constants.Book.Stage.Planned) {
      setIsEdlNameReadOnly(false);
    } else {
      setIsEdlNameReadOnly(true);
    }
  };

  return [
    {
      request: 'crt.LoadDataRequest',
      handler: (request: LoadDataRequest, next): any => {
        if (request.dataSourceName === 'GridDetail_l8d938fDS') {
          loadAuthorList();
        }
        return next?.handle(request);
      }
    },
    {
      request: 'crt.DataGridCreateItemRequest',
      handler: async(request: DataGridCreateItemRequest, next): Promise<unknown> => {
        const result = await next?.handle(request);

        if (request.dataGridName === 'EdlBookAuthor') {
          loadAuthorList();
        }
        return result;
      }
    }
  ];
};
