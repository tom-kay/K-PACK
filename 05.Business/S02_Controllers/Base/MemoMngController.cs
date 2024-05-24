using log4net;
using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S02_Controllers.Base
{
    internal class MemoMngController
    {
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        MemoMngDao dao;

        public MemoMngController()
        {
            dao = new MemoMngDao();
        }

        internal List<MemoTemplateDto> GetMemoList(MemoTemplateDto param)
        {
            List<MemoTemplateDto> list = dao.SelectMemoList(param);

            return list;
        }

        internal MemoTemplateDto GetMemo(MemoTemplateDto param)
        {
            MemoTemplateDto memo = dao.SelectMemoSingle(param);

            return memo;
        }

        internal int? AddMemo(MemoTemplateDto param)
        {
            int iSave = dao.InsertMemo(param);

            if (iSave < 0) return null;

            return iSave;
        }

        internal bool RemoveMemo(MemoTemplateDto param)
        {
            bool isDelete = true;

            int iDelete = dao.DeleteMemo(param);

            if(iDelete < 0) isDelete = false;

            return isDelete;
        }

        internal List<MemoTemplateDto> GetTemplatePopup(MemoTemplateDto param)
        {
            List<MemoTemplateDto> list = dao.SelectTemplatePopupList(param);

            return list;
        }
    }
}
