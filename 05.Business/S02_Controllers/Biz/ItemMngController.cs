using log4net;
using P05_Business.S01_Models.Dao.Biz;
using P05_Business.S01_Models.Dto.Biz;
using System.Collections.Generic;
using System.Reflection;

namespace P05_Business.S02_Controllers.Biz
{
    internal class ItemMngController
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        ItemMngDao dao;

        internal ItemMngController()
        {
            dao = new ItemMngDao();
        }

        #region -- Item Group
        internal List<ItemGroupDto> GetItemGroupList(ItemGroupDto param)
        {

            List<ItemGroupDto> list = dao.SelectItemGroupList(param);

            return list;

        }

        internal ItemGroupDto GetItemGroup(ItemGroupDto param)
        {

            //아이템 그룹 조회
            ItemGroupDto group = dao.SelectItemGroup(param);

            //상세 아이템 조회
            if (group != null && !string.IsNullOrEmpty(group.GroupCode))
            {
                ItemDto item = new ItemDto();
                item.GroupCode = group.GroupCode;
                item.CompanyCode = group.CompanyCode;

                group.Items = dao.SelectItemList(item);
            }


            return group;

        }

        internal int AddItemGroup(ItemGroupDto param)
        {
            int iSave = dao.InsertItemGroup(param);

            return iSave;
        }

        internal int RemoveItemGroup(ItemGroupDto param)
        {
            int iDelete = dao.DeleteItemGroup(param);

            return iDelete;

        }
        #endregion -- Item Group

        #region -- Item
        internal List<ItemDto> GetItemList(ItemDto param)
        {

            List<ItemDto> list = dao.SelectItemList(param);

            return list;

        }

        internal ItemDto GetItem(ItemDto param)
        {

            ItemDto item = dao.SelectItem(param);

            return item;

        }

        internal int AddItem(ItemDto param)
        {
            int iSave = dao.InsertItem(param);

            return iSave;
        }

        internal int RemoveItem(ItemDto param)
        {
            int iDelete = dao.DeleteItem(param);

            return iDelete;

        } 
        #endregion -- Item

    }
}
