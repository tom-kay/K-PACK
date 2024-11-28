using log4net;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
    public partial class frmMemoMng : frmEditContainer
    {
        #region -- Member Variable
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        MemoMngController ctrl;
        MemoTemplateDto dto;

        int? _MEMO_IDX;
        #endregion -- Member Variable

        #region -- Constructor
        public frmMemoMng()
        {
            InitializeComponent();

            ctrl = new MemoMngController();
            dto = new MemoTemplateDto();

            Set_Menu_Button(new EditButtonSettings { isPrint = false, isSearch = false });

            _MEMO_IDX = 0;
        }

        public frmMemoMng(string code) : this()
        {
            int idx;
            int.TryParse(code, out idx);

            _MEMO_IDX = idx;

            IS_LINK_OPEN = true;

            txtTitle.Enabled = false;
        }
        #endregion -- Constructor

        #region -- Controls Events
        private void frmMemoMng_Load(object sender, EventArgs e)
        {
            try
            {
                if (IS_LINK_OPEN)
                {
                    SearchData(_MEMO_IDX);
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            try
            {
                IS_LINK_OPEN = false;

                _MEMO_IDX = null;

                txtTitle.Enabled = true;

            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (_MEMO_IDX == null)
                {
                    KMessageBox.Show("조회화면에서 링크로 조회 바랍니다.", "조회", MessageBoxButtons.OK);
                    return;
                }

                if (SearchData(_MEMO_IDX) == ResultCRUD.SaveSuccessData)
                {
                    MainMessage.Show("조회 되었습니다.");
                }
                else
                {
                    MainMessage.Show("자료가 없습니다.");
                }

            }
            catch(Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTitle.Texts.Trim()))
                {
                    KMessageBox.Show("[제목]을 입력 바랍니다.", "저장", MessageBoxButtons.OK);
                    return;
                }

                if (string.IsNullOrEmpty(txtContents.Texts.Trim()))
                {
                    KMessageBox.Show("[내용]을 입력 바랍니다.", "저장", MessageBoxButtons.OK);
                    return;
                }

                if (KMessageBox.Show("저장하시겠습니까?", "저장", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                
                if (SaveData() == ResultCRUD.SaveSuccessData)
                {
                    MainMessage.Show("저장되었습니다.");
                }
                else
                {
                    KMessageBox.Show("저장되지 않았습니다.", "저장", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_MEMO_IDX == null)
                {
                    KMessageBox.Show("삭제할 대상이 없습니다.", "삭제", MessageBoxButtons.OK);
                    return;
                }

                if (KMessageBox.Show("삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                if (DeleteData() == ResultCRUD.DeleteSuccessData)
                {
                    MainMessage.Show("삭제되었습니다.");
                }
                else
                {
                    KMessageBox.Show("삭제되지 않았습니다.", "저장", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion -- Controls Events

        #region -- Methods
        private ResultCRUD SearchData(int? idx)
        {
            MemoTemplateDto param = new MemoTemplateDto
            {
                MemoIdx = idx,
                CompanyCode = LoginCompany.CompanyCode,
            };

            dto = ctrl.GetMemo(param);

            DataHandles.DtoToControls<MemoTemplateDto>(this, dto);

            ResultCRUD result;
            if (dto != null)
            {
                result = ResultCRUD.SearchSuccessData;
            }
            else
            {
                result = ResultCRUD.SearchSuccessNoData;
            }

            return result;
        }
        private ResultCRUD SaveData()
        {
            
            MemoTemplateDto saveData = DataHandles.ControlsToDto(this, dto);

            MemoTemplateDto param = new MemoTemplateDto
            {
                MemoIdx = _MEMO_IDX,
                Title= saveData.Title,
                Contents = saveData.Contents,
                CompanyCode = LoginCompany.CompanyCode,
                CreateId = LoginUserInfo.UserId, 
                UpdateId = LoginUserInfo.UserId,
            };

            //유효성 검사
            //var context = new ValidationContext(param, serviceProvider: null, items: null);
            //Validator.ValidateObject(param, context, validateAllProperties: true);

            int? idx = ctrl.AddMemo(param);

            ResultCRUD result = ResultCRUD.None;
            if (idx != null)
            {
                _MEMO_IDX = idx;

                txtTitle.Enabled = false;

                SearchData(_MEMO_IDX);

                result = ResultCRUD.SaveSuccessData;
            }

            return result;
        }

        private ResultCRUD DeleteData()
        {
            MemoTemplateDto saveData = DataHandles.ControlsToDto(this, dto);

            MemoTemplateDto param = new MemoTemplateDto
            {
                MemoIdx = _MEMO_IDX,
                CompanyCode = LoginCompany.CompanyCode,
                DeleteId = LoginUserInfo.UserId,
            };

            //유효성 검사
            //var context = new ValidationContext(param, serviceProvider: null, items: null);
            //Validator.ValidateObject(param, context, validateAllProperties: true);

            bool isDelete = ctrl.RemoveMemo(param);

            ResultCRUD result;
            if (isDelete)
            {//삭제성공
                MainMessage.Show("삭제되었습니다.");
                btnInit.PerformClick();

                result = ResultCRUD.DeleteSuccessData;
            }
            else
            {//삭제실패
                result = ResultCRUD.SaveFailData;
            }

            return result;
        }

        #endregion -- Methods
    }
}
