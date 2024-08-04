﻿using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;
using log4net;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Biz;
using P05_Business.S02_Controllers.Biz;
using P05_Business.S04_Reports.Rpt;
using P05_Business.S04_Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;

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

            InitGrid();

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
                    spdContainerList.DataSource = DataHandles.ConvertToDataTable<ExportContainerDto>(dtoContainers);
                    (spdContainerList.DataSource as DataTable).AcceptChanges();
                }

                //PackingList 정보 바인딩
                dtoPackings = dtoMaster.ExportPackings;
                if (dtoPackings != null)
                {
                    //spdContainerList.DataSource = DataHandles.ConvertToDataTable<ExportContainerDto>(dtoPackings);
                    //(spdContainerList.DataSource as DataTable).AcceptChanges();
                }

                //Invoice 정보 바인딩
                dtoInvoices = dtoMaster.ExportInvoices;
                if (dtoInvoices != null)
                {
                    //spdContainerList.DataSource = DataHandles.ConvertToDataTable<ExportContainerDto>(dtoInvoices);
                    //(spdContainerList.DataSource as DataTable).AcceptChanges();
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

            ExportMasterDto param = new ExportMasterDto
            {
                InvoiceNo = saveMaster.InvoiceDate,
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
                //ExportPackings = savePackings,
                //ExportInvoices = saveInvoices,
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
            GridHelper.CreateGrid(spdContainerList);
            GridHelper.AddTextColumn(spdContainerList, "ContainerNo", "Cntr No.", true, true, 150, CellHorizontalAlignment.Left, CellVerticalAlignment.Center);
            GridHelper.AddTextColumn(spdContainerList, "SealNo1", "Seal No.1", true, true, 100, CellHorizontalAlignment.Left, CellVerticalAlignment.Center);
            GridHelper.AddTextColumn(spdContainerList, "SealNo2", "Seal No.2", true, true, 100, CellHorizontalAlignment.Left, CellVerticalAlignment.Center);
            GridHelper.AddTextColumn(spdContainerList, "SealNo3", "Seal No.3", true, true, 100, CellHorizontalAlignment.Left, CellVerticalAlignment.Center);
            GridHelper.EndGrid(spdContainerList);
        }

        private void InitControls()
        {
            isFormChagned = false;

            _MODE = SAVE_MODE.New;

            txtInvoiceNo.Enabled = true;
            tabExportSub.SelectedIndex = 0;
            cnbBuyer.AddParams = new object[] { "S" };
            cnbShipper.AddParams = new object[] { "C" };
            cnbConsignee.AddParams = new object[] { "S" };
            cnbNotify.AddParams = new object[] { "S" };

            dtoMaster = new ExportMasterDto();
            dtoContainers = new List<ExportContainerDto>();
            dtoPackings = new List<ExportPackingDto>();
            dtoInvoices = new List<ExportInvoiceDto>();

            //그리드 초기화
            spdContainerList.DataSource = DataHandles.ConvertToDataTable<ExportContainerDto>(dtoContainers);
            
            InitDto();
        }

        private void InitDto()
        {

            base.currentData = dtoMaster;         //원본 데이터
            base.isFormChagned = false;
        }

        #endregion -- Method

        
    }
}
