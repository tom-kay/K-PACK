using FarPoint.Excel.EntityClassLibrary.SpreadsheetML;
using FarPoint.Win.Spread;
using GrapeCity.Spreadsheet;
using log4net;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P02_K_CONTROL_WIN;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S01_Models.Dto.Biz;
using P05_Business.S02_Controllers.Base;
using P05_Business.S02_Controllers.Biz;
using P05_Business.S03_Views.Popup.Biz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Biz
{
    public partial class frmExportMng : frmEditContainer
    {
        #region -- Variables
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        SAVE_MODE _MODE = SAVE_MODE.New;

        ExportMngController ctrl;

        ExportMasterDto dtoMaster;
        List<ExportContainerDto> dtoContainers;
        List<ExportPackingDto> dtoPackings;
        List<ExportInvoiceDto> dtoInvoices;

        #endregion -- Variables

        #region -- Constructor
        public frmExportMng()
        {
            InitializeComponent();

            Set_Menu_Button(new EditButtonSettings { isSearch = false });

            _MODE = SAVE_MODE.New;

            cnbBuyer.OnCodeChanged += CnbCode_OnCodeChanged;
            cnbConsignee.OnCodeChanged += CnbCode_OnCodeChanged;
            cnbNotify.OnCodeChanged += CnbCode_OnCodeChanged;
            cnbShipper.OnCodeChanged += CnbCode_OnCodeChanged;

            InitControls();
        }

        public frmExportMng(string code) : this()
        {
            IS_LINK_OPEN = true;

            _MODE = SAVE_MODE.Update;

            txtInvoiceNo.Texts = code;


        }
        #endregion -- Constructor

        #region -- Control Event

        private void frmExportMng_Load(object sender, EventArgs e)
        {

            try
            {
                InitGrid();

                InitCombo();

                if (IS_LINK_OPEN) SearchData();

            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
/*
                AccessMain.ShowLoading();

                // 데이터 조회
                OrderMasterDto param = new OrderMasterDto
                {
                    OrderNo = txtOrderNo.Texts.Trim(),
                    CompanyCode = LoginCompany.CompanyCode,
                };

                List<OrderReportDto> reportDtos = ctrl.GetReportOrderData(param);

                DataTable dtReport = DataHandles.ConvertToDataTable(reportDtos);
                dtReport.TableName = "OrderDt";

                DataTable dtCom = new DataTable();
                dtCom.Columns.Add("CompanyCode", typeof(string));
                dtCom.Columns.Add("Nationality", typeof(string));
                dtCom.Columns.Add("HeadOffice", typeof(string));
                dtCom.Columns.Add("CompanyGroup", typeof(string));
                dtCom.Columns.Add("CompanyNameK", typeof(string));
                dtCom.Columns.Add("CompanyNameE", typeof(string));
                dtCom.Columns.Add("TelNo", typeof(string));
                dtCom.Columns.Add("FaxNo", typeof(string));
                dtCom.Columns.Add("AddressK1", typeof(string));
                dtCom.Columns.Add("AddressK2", typeof(string));
                dtCom.Columns.Add("AddressE1", typeof(string));
                dtCom.Columns.Add("AddressE2", typeof(string));

                DataRow drCom = dtCom.NewRow();
                drCom["CompanyCode"] = LoginCompany.CompanyCode;
                drCom["Nationality"] = LoginCompany.NationalityCode;
                drCom["HeadOffice"] = LoginCompany.HeadOffice;
                drCom["CompanyGroup"] = LoginCompany.CompanyGroup;
                drCom["CompanyNameK"] = LoginCompany.CompanyNameK;
                drCom["CompanyNameE"] = LoginCompany.CompanyNameE;
                drCom["TelNo"] = LoginCompany.TelNo;
                drCom["FaxNo"] = LoginCompany.FaxNo;
                drCom["AddressK1"] = LoginCompany.AddressK1;
                drCom["AddressK2"] = LoginCompany.AddressK2;
                drCom["AddressE1"] = LoginCompany.AddressE1;
                drCom["AddressE2"] = LoginCompany.AddressE2;
                dtCom.Rows.Add(drCom);
                dtCom.TableName = "CompanyInfo";

                DataSet ds = new DataSet();
                ds.Tables.Add(dtReport);
                ds.Tables.Add(dtCom);

                rptOrderDucu rpt = new rptOrderDucu();
                rpt.SetDataSource(ds);
                //rpt.SetParameterValue("MyParameter", "Hello");    //파라미터 설정
                //rpt.DataDefinition.FormulaFields["MyFormula"].Text = "'" + textBox1.Text + "'";       //포뮬러 설정

                frmReportMain frmReport = new frmReportMain();
                frmReport.reportViewer.ReportSource = rpt;
                frmReport.reportViewer.RefreshReport();

                AccessMain.HideLoading();

                frmReport.ShowDialog(this);
*/
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
                InitControls();
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
                if (string.IsNullOrEmpty(txtInvoiceNo.Texts.Trim()))
                {
                    KMessageBox.Show("[INV NO.]를 입력 바랍니다.", "조회", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ResultCRUD search = SearchData();

                if (search == ResultCRUD.SearchSuccessData)
                {
                    MainMessage.Show("조회되었습니다.");
                }
                else
                {
                    MainMessage.Show("자료가 없습니다.");
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //validation
                if (string.IsNullOrEmpty(txtInvoiceNo.Texts.Trim()))
                {
                    KMessageBox.Show("[INV NO.]를 입력 바랍니다.", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrEmpty(cnbShipper.CodeValue.Trim()))
                {
                    KMessageBox.Show("[SHIPPER]를 입력 바랍니다.", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrEmpty(cnbBuyer.CodeValue.Trim()))
                {
                    KMessageBox.Show("[BUYER]를 입력 바랍니다.", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (KMessageBox.Show("저장 하시겠습니까?", "저장", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                ResultCRUD save = SaveData();

                if (save == ResultCRUD.SaveSuccessData)
                {
                    SearchData();   //저장된 데이터 조회

                    MainMessage.Show("저장되었습니다.");
                }
                else
                {
                    MainMessage.Show("저장되지 않았습니다.");
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
                //validation
                if (string.IsNullOrEmpty(txtInvoiceNo.Texts.Trim()))
                {
                    KMessageBox.Show("[INV NO.]를 입력 바랍니다.", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (KMessageBox.Show("삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


                ResultCRUD delete = DeleteData();

                if (delete == ResultCRUD.DeleteSuccessData)
                {
                    MainMessage.Show("삭제 되었습니다.");
                }
                else
                {
                    MainMessage.Show("삭제되지 않았습니다.");
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCntrAddRow_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = spdContainerList.ActiveSheet.DataSource as DataTable;

                if (dt != null)
                {
                    DataRow drNew = dt.NewRow();
                    drNew["InvoiceNo"] = txtInvoiceNo.Texts;
                    dt.Rows.Add(drNew);
                }

                base.isFormChagned = true;
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCntrDelRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (spdContainerList.ActiveSheet.Rows.Count < 1)
                {
                    KMessageBox.Show("삭제할 데이터가 없습니다.", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int activeRowIdx = spdContainerList.ActiveSheet.ActiveRowIndex;
                if (activeRowIdx >= 0)
                {
                    if (KMessageBox.Show($"[{activeRowIdx + 1}]행을 삭제 하시겠습니까? ", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }

                    DataTable dt = spdContainerList.ActiveSheet.DataSource as DataTable;
                    dt.Rows[activeRowIdx].Delete();

                    base.isFormChagned = true;
                }

            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 거래처 코드 변경 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CnbCode_OnCodeChanged(object sender, EventArgs e)
        {
            string custCode = string.Empty;
            string custAddr = string.Empty;
            //이벤트가 발생한 거래처의 주고를 가져와서 주소란에 바인딩한다.
            switch ((sender as KCodeNameBox).Name)
            {
                case "cnbBuyer":
                    custCode = cnbBuyer.CodeValue;
                    custAddr = GetCustomerAddr(custCode, false);
                    txtBuyerAddress.Texts = custAddr;
                    break;
                case "cnbShipper":
                    custCode = cnbShipper.CodeValue;
                    custAddr = GetCustomerAddr(custCode, false);
                    txtShipperAddress.Texts = custAddr;
                    break;
                case "cnbConsignee":
                    custCode = cnbConsignee.CodeValue;
                    custAddr = GetCustomerAddr(custCode, false);
                    txtConsigneeAddress.Texts = custAddr;
                    break;
                case "cnbNotify":
                    custCode = cnbNotify.CodeValue;
                    custAddr = GetCustomerAddr(custCode, true);
                    txtNotifyAddress.Texts = custAddr;
                    break;
            }
        }

        private void btnPkgAdd_Click(object sender, EventArgs e)
        {
            try
            {
                List<OrderDetailDto> addOrderDetails = null;

                //기존에 있는 아이템을 팝업으로 넘긴다.
                List<ExportPackingDto> listOrderDetail = DataHandles.ConvertToList<ExportPackingDto>(spdPackingList.DataSource as DataTable);
                object[] param = { 
                    cnbBuyer.CodeValue,
                    cnbBuyer.NameValue,
                    listOrderDetail,
                };

                using (frmPoFindPopup popup = new frmPoFindPopup("발주조회", param))
                {
                    if (popup.ShowDialog(this) == DialogResult.OK)
                    {
                        if (popup.ResultItems != null)
                        {
                            addOrderDetails = popup.ResultItems;
                        }
                    }
                }

                // 팝업에서 받은 아이템을 그리드에 바인딩한다.
                if (addOrderDetails != null)
                {
                    this.SetBindAddItems(addOrderDetails);

                    base.isFormChagned = true;
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetBindAddItems(List<OrderDetailDto> addOrderItems)
        {
            List<ExportPackingDto> listPackings = DataHandles.ConvertToList<ExportPackingDto>(spdPackingList.DataSource as DataTable);

            foreach (OrderDetailDto item in addOrderItems)
            {
                int index = listPackings.FindIndex(i => i.OrderNo == item.OrderNo && i.OrderDetailId == item.DetailId);

                if (index >= 0) continue;

                DataTable dt = spdPackingList.DataSource as DataTable;
                DataRow newDr = dt.NewRow();
                newDr["InvoiceNo"] = txtInvoiceNo.Texts;
                newDr["OrderNo"] = item.OrderNo;
                newDr["BuyerPoNo"] = item.BuyerPoNo;
                newDr["OrderDetailId"] = item.DetailId;
                newDr["ItemNo"] = item.ItemNo;
                newDr["ItemDescription"] = item.Description;
                dt.Rows.Add(newDr);
            }
        }

        private void btnInvAdd_Click(object sender, EventArgs e)
        {
            

        }

        #endregion -- Control Event

        #region -- Method

        private ResultCRUD SearchData()
        {
            ExportMasterDto param = new ExportMasterDto
            {
                InvoiceNo = txtInvoiceNo.Texts.Trim(),
                CompanyCode = LoginCompany.CompanyCode,
            };

            dtoMaster = ctrl.GetExportMaster(param);

            ResultCRUD search;
            if (dtoMaster != null && !string.IsNullOrEmpty(dtoMaster.InvoiceNo))
            {
                search = ResultCRUD.SearchSuccessData;

                isFormChagned = false;

                _MODE = SAVE_MODE.Update;   //수정모드로 변경

                DataHandles.DtoToControls(this, dtoMaster); //마스터 데이터 바이딩

                txtInvoiceNo.Enabled = false;

                /*그리드 데이터 바인딩*/
                //Container 정보 바인딩
                dtoContainers = dtoMaster.ExportContainers;
                if (dtoContainers != null)
                {
                    spdContainerList.ActiveSheet.DataSource = DataHandles.ConvertToDataTable<ExportContainerDto>(dtoContainers);
                    (spdContainerList.ActiveSheet.DataSource as DataTable).AcceptChanges();
                }

                //PackingList 정보 바인딩
                dtoPackings = dtoMaster.ExportPackings;
                if (dtoPackings != null)
                {
                    spdPackingList.DataSource = DataHandles.ConvertToDataTable<ExportPackingDto>(dtoPackings);
                    (spdPackingList.DataSource as DataTable).AcceptChanges();
                }

                //Invoice 정보 바인딩
                dtoInvoices = dtoMaster.ExportInvoices;
                if (dtoInvoices != null)
                {
                    spdInvoiceList.DataSource = DataHandles.ConvertToDataTable<ExportInvoiceDto>(dtoInvoices);
                    (spdInvoiceList.DataSource as DataTable).AcceptChanges();
                }

            }
            else
            {
                search = ResultCRUD.SearchSuccessNoData;
            }

            InitDto();


            return search;
        }

        private ResultCRUD SaveData()
        {
            //Master 정보 수집
            ExportMasterDto saveMaster = DataHandles.ControlsToDto<ExportMasterDto>(this, dtoMaster);

            //Container 정보 수집
            DataTable dtContainer = UserDataGrid.GetAllData(spdContainerList);
            List<ExportContainerDto> saveContainers = null;
            if (dtContainer != null)
            {
                saveContainers = DataHandles.ConvertToList<ExportContainerDto>(dtContainer);
            }

            DataTable dtPacking = UserDataGrid.GetAllData(spdPackingList);
            List<ExportPackingDto> savePackings = null;
            if(dtPacking != null)
            {
                savePackings = DataHandles.ConvertToList<ExportPackingDto>(dtPacking);
            }

            DataTable dtInvoice = UserDataGrid.GetAllData(spdInvoiceList);
            List<ExportInvoiceDto> saveInvoices = null;
            if (dtInvoice != null)
            {
                saveInvoices = DataHandles.ConvertToList<ExportInvoiceDto>(dtInvoice);
            }

            ExportMasterDto param = new ExportMasterDto
            {
                InvoiceNo = saveMaster.InvoiceNo,
                InvoiceDate = saveMaster.InvoiceDate,
                ShipperCode = saveMaster.ShipperCode,
                ShipperAddress = saveMaster.ShipperAddress,
                ConsigneeCode = saveMaster.ConsigneeCode,
                ConsigneeAddress = saveMaster.ConsigneeAddress,
                NotifyCode = saveMaster.NotifyCode,
                NotifyAddress = saveMaster.NotifyAddress,
                BuyerCode = saveMaster.BuyerCode,
                BuyerAddress = saveMaster.BuyerAddress,
                DepartureDate = saveMaster.DepartureDate,
                CarrierName = saveMaster.CarrierName,
                PolCode = saveMaster.PolCode,
                PodCode = saveMaster.PodCode,
                DestinationName = saveMaster.DestinationName,
                DeliveryTermCode = saveMaster.DeliveryTermCode,
                PaymentTermCode = saveMaster.PaymentTermCode,
                PaymentDesc = saveMaster.PaymentDesc,
                Measurement = saveMaster.Measurement,
                NetWeight = saveMaster.NetWeight,
                GrossWeight = saveMaster.GrossWeight,
                ShippingMark = saveMaster.ShippingMark,
                Remark = saveMaster.Remark,
                PackingRemark = saveMaster.PackingRemark,
                InvoiceRemark = saveMaster.InvoiceRemark,
                CompanyCode = LoginCompany.CompanyCode,
                CreateId = LoginUserInfo.UserId,
                UpdateId = LoginUserInfo.UserId,
                DeleteId = LoginUserInfo.UserId,
                ExportContainers = saveContainers,
                ExportPackings = savePackings,
                ExportInvoices = saveInvoices,
            };

            RequestCRUD request;
            if (_MODE == SAVE_MODE.New)
            {
                request = RequestCRUD.Create;
            }
            else
            {
                request = RequestCRUD.Update;
            }

            bool isSave = ctrl.AddExportMaster(param, request);

            ResultCRUD result;
            if (isSave)
            {
                result = ResultCRUD.SaveSuccessData;
            }
            else
            {
                result = ResultCRUD.SaveFailData;
            }

            return result;
        }

        private ResultCRUD DeleteData()
        {
            ExportMasterDto param = new ExportMasterDto()
            {
                InvoiceNo = txtInvoiceNo.Texts,
                CompanyCode = LoginCompany.CompanyCode,
                DeleteId = LoginUserInfo.UserId,
            };

            bool isDelete = ctrl.RemoveExportMaster(param);

            ResultCRUD result;
            if (isDelete)
            {
                result = ResultCRUD.DeleteSuccessData;
            }
            else
            {
                result = ResultCRUD.DeleteFailData;
            }

            return result;
        }

        private void InitGrid()
        {
            // Container List
            SpreadHelper.CreateSpread(spdContainerList, "ContainerList");
            SpreadHelper.AddTextColumn(spdContainerList, "InvoiceNo", "INV.NO", true, false, 0, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdContainerList, "ContainerId", "CNTR.ID", true, false, 0, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdContainerList, "ContainerNo", "CNTR.NO", true, true, 250, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdContainerList, "SealNo1", "SEAL.NO.1", true, true, 200, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdContainerList, "SealNo2", "SEAL.NO.2", true, true, 200, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdContainerList, "SealNo3", "SEAL.NO.3", true, true, 200, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.EndSpread(spdContainerList);

            //그리드 초기화
            spdContainerList.DataSource = DataHandles.ConvertToDataTable<ExportContainerDto>(dtoContainers);

            // Packing List
            SpreadHelper.CreateSpread(spdPackingList, "PackingList");
            SpreadHelper.AddTextColumn(spdPackingList, "InvoiceNo", "INV.NO", true, false, 0, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdPackingList, "PackingId", "PACK.ID", true, false, 0, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdPackingList, "OrderNo", "ORD.NO", false, true, 200, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdPackingList, "OrderDetailId", "ORD.DTL.ID", true, false, 0, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdPackingList, "ItemNo", "ITEM.NO", true, true, 200, 100, SpreadHelper.GridHorizontalAlignment.Left);
            SpreadHelper.AddTextColumn(spdPackingList, "ItemDescription", "ITEM.DESC", true, true, 300, 100, SpreadHelper.GridHorizontalAlignment.Left);
            SpreadHelper.AddTextColumn(spdPackingList, "PkgUnitCode", "PKG.UNIT.CODE", true, false, 0, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdPackingList, "PkgUnitName", "PKG.UNIT.NAME", true, true, 200, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdPackingList, "PkgStartNo", "PKG.NO", true, true, 100, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdPackingList, "PkgEndNo", "PKG.NO", true, true, 100, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdPackingList, "Qty", "Q'TY", true, true, 100, 200, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdPackingList, "PkgQty", "PKG.Q'TY", true, true, 200, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.MergeColumnHeader(spdPackingList, "PkgStartNo", 2);
            SpreadHelper.EndSpread(spdPackingList);

            spdPackingList.DataSource = DataHandles.ConvertToDataTable<ExportPackingDto>(dtoPackings);

            // Invoice List
            SpreadHelper.CreateSpread(spdInvoiceList, "InvoiceList");
            SpreadHelper.AddTextColumn(spdInvoiceList, "InvoiceNo", "INV.NO", true, false, 0, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdInvoiceList, "InvoiceId", "INV.ID", true, false, 0, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdInvoiceList, "OrderNo", "ORD.NO", true, false, 100, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdInvoiceList, "OrderDetailId", "ORD.ID", true, false, 0, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddTextColumn(spdPackingList, "BuyerPoNo", "P/O.NO", true, true, 200, 100, SpreadHelper.GridHorizontalAlignment.Center);
            SpreadHelper.AddNumberColumn(spdInvoiceList, "ItemLength", "제품 길이", true, true, 300, 0, true);
            SpreadHelper.AddNumberColumn(spdInvoiceList, "UsQty", "미환산 수량", true, true, 300, 0, true);
            SpreadHelper.AddNumberColumn(spdInvoiceList, "Qty", "수량", true, true, 300, 0, true);
            SpreadHelper.AddNumberColumn(spdInvoiceList, "UnitPrice", "단가", true, true, 300, 4, true);
            SpreadHelper.AddNumberColumn(spdInvoiceList, "Amount", "금액", true, true, 300, 0, true);
            SpreadHelper.EndSpread(spdInvoiceList);

            spdInvoiceList.DataSource = DataHandles.ConvertToDataTable<ExportInvoiceDto>(dtoInvoices);


        }

        private void InitControls()
        {
            isFormChagned = false;

            _MODE = SAVE_MODE.New;

            txtInvoiceNo.Enabled = true;
            tabExportSub.SelectedIndex = 0;
            cnbBuyer.AddParams = cnbShipper.AddParams = cnbConsignee.AddParams = cnbNotify.AddParams = new object[] { "A" };    //기본값 : 전체
            cnbPol.AddParams = cnbPod.AddParams = new object[] { "S" };  //기본값 : 해운

            ctrl = new ExportMngController();

            dtoMaster = new ExportMasterDto();
            dtoContainers = new List<ExportContainerDto>();
            dtoPackings = new List<ExportPackingDto>();
            dtoInvoices = new List<ExportInvoiceDto>();

            //그리드 초기화
            spdContainerList.DataSource = DataHandles.ConvertToDataTable<ExportContainerDto>(dtoContainers);
            spdPackingList.DataSource = DataHandles.ConvertToDataTable<ExportPackingDto>(dtoPackings);
            spdInvoiceList.DataSource = DataHandles.ConvertToDataTable<ExportInvoiceDto>(dtoInvoices);
            
            InitDto();
        }

        private void InitDto()
        {

            base.currentData = dtoMaster;         //원본 데이터
            base.isFormChagned = false;
        }

        /// <summary>
		/// 콤보박스 초기설정
		/// </summary>
		private void InitCombo()
        {
            ComboHelper.InitComboBox(cboDeliveryTerm, "DELIVERYTERMS", false, true);
            ComboHelper.InitComboBox(cboPaymentTerm, "PAYMENTTERMS", false, true);
        }

        /// <summary>
        /// 거래처 주소를 가져온다.
        /// </summary>
        /// <param name="custCode"></param>
        /// <param name="isOption"></param>
        /// <returns></returns>
        private string GetCustomerAddr(string custCode, bool isOption)
        {
            CustomerDto param = new CustomerDto()
            {
                CustCode = custCode,
                CompanyCode = LoginCompany.CompanyCode,
            };

            CustomerDto custDto = new CustomerMngController().GetCustomer(param);

            StringBuilder sb = new StringBuilder();
            if (custDto != null)
            {   
                sb.AppendLine(custDto.Address1);
                sb.AppendLine(custDto.Address2);
                if (isOption)
                {
                    sb.Append($"TEL: {custDto.TelNo}");
                    sb.Append(", ");
                    sb.AppendLine($"FAX: {custDto.FaxNo}");
                    sb.Append("ATTN: ");
                }
            }

            return sb.ToString();
        }

        #endregion -- Method

        
    }
}
