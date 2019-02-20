using CMST.Storage.BackgroundManage.Common;
using CMST.Storage.BackgroundManage.Data;
using CMST.Storage.BackgroundManage.Service;
using CMSTMsgBox;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMST.Storage.BackgroundManage.Presenter
{
    public class FrmBaseMessagePresenter
    {
        public FrmBaseMessageManage View { get; set; }
        private BaseMessageService MyBaseMessageService = new BaseMessageService();
        int storageRowIndex = -1;
        int outboundRowIndex = -1;
        int measureRowIndex = -1;
        int depotsRowIndex = -1;
        int rateTypeRowIndex = -1;
        public FrmBaseMessagePresenter(FrmBaseMessageManage view)
        {
            this.View = view;
            SetEvent();
            LoadStorageWayData();
            this.View.TxtStorageName.Enabled = false;
            this.View.TxtStorageRemark.Enabled = false;
            this.View.CboStorageIfUse.Enabled = false;
            this.View.BtnStorageSave.Enabled = false;
            this.View.BtnStorageAdd.Enabled = true;
        }

        public void SetEvent()
        {
            this.View.TcBaseMessage.SelectedIndexChanged += new EventHandler(TcBaseMessageChanged);
            this.View.BtnStorageAdd.Click += new EventHandler(BtnStorageAdd);
            this.View.BtnStorageSave.Click += new EventHandler(BtnStorageSave);
            this.View.DgvStorage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(StorageRowClick);
            this.View.DgvStorage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(StorageRowDoubleClick);
            this.View.DgvStorage.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(DgvStorageRowPostPaint);

            this.View.BtnOutboundAdd.Click += new EventHandler(BtnOutboundAdd);
            this.View.BtnOutboundSave.Click += new EventHandler(BtnOutboundSave);
            this.View.DgvOutbound.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(OutboundRowClick);
            this.View.DgvOutbound.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(OutboundRowDoubleClick);
            this.View.DgvOutbound.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(DgvOutboundRowPostPaint);

            this.View.BtnMeasureAdd.Click += new EventHandler(BtnMeasureAdd);
            this.View.BtnMeasureSave.Click += new EventHandler(BtnMeasureSave);
            this.View.DgvMeasure.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(MeasureRowClick);
            this.View.DgvMeasure.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(MeasureRowDoubleClick);
            this.View.DgvMeasure.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(DgvMeasureRowPostPaint);

            this.View.BtnDepotsAdd.Click += new EventHandler(BtnDepotsAdd);
            this.View.BtnDepotsSave.Click += new EventHandler(BtnDepotsSave);
            this.View.DgvDepots.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(DepotsRowClick);
            this.View.DgvDepots.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(DepotsRowDoubleClick);
            this.View.DgvDepots.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(DgvDepotsRowPostPaint);

            this.View.BtnRateTypeAdd.Click += new EventHandler(BtnRateTypeAdd);
            this.View.BtnRateTypeSave.Click += new EventHandler(BtnRateTypeSave);
            this.View.DgvRateType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(RateTypeRowClick);
            this.View.DgvRateType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(RateTypeRowDoubleClick);
            this.View.DgvRateType.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(DgvRateTypeRowPostPaint);
        }
        public void TcBaseMessageChanged(object sender, EventArgs e)
        {
            if (this.View.TcBaseMessage.SelectedTab.Name == "tpStorageWay")
            {
                LoadStorageWayData();
                this.View.TxtStorageName.Enabled = false;
                this.View.TxtStorageRemark.Enabled = false;
                this.View.CboStorageIfUse.Enabled = false;
                this.View.BtnStorageSave.Enabled = false;
                this.View.BtnStorageAdd.Enabled = true;
            }
            else if (this.View.TcBaseMessage.SelectedTab.Name == "tpOutboundWay")
            {
                LoadOutboundWayData();
                this.View.TxtOutboundName.Enabled = false;
                this.View.TxtOutboundRemark.Enabled = false;
                this.View.CboOutboundIfUse.Enabled = false;
                this.View.BtnOutboundSave.Enabled = false;
                this.View.BtnOutboundAdd.Enabled = true;
            }
            else if (this.View.TcBaseMessage.SelectedTab.Name == "tpMeasureWay")
            {
                LoadMeasureWayData();
                this.View.TxtMeasureName.Enabled = false;
                this.View.TxtMeasureRemark.Enabled = false;
                this.View.CboMeasureIfUse.Enabled = false;
                this.View.BtnMeasureSave.Enabled = false;
                this.View.BtnMeasureAdd.Enabled = true;
            }
            else if (this.View.TcBaseMessage.SelectedTab.Name == "tpDepotsProperty")
            {
                LoadDepotsPropertyData();
                this.View.TxtDepotsName.Enabled = false;
                this.View.TxtDepotsRemark.Enabled = false;
                this.View.CboDepotsIfUse.Enabled = false;
                this.View.BtnDepotsSave.Enabled = false;
                this.View.BtnDepotsAdd.Enabled = true;
            }
            else if (this.View.TcBaseMessage.SelectedTab.Name == "tpRateType")
            {
                LoadRateTypeData();
                this.View.TxtRateTypeName.Enabled = false;
                this.View.TxtRateTypeRemark.Enabled = false;
                this.View.CboRateTypeIfUse.Enabled = false;
                this.View.BtnRateTypeSave.Enabled = false;
                this.View.BtnRateTypeAdd.Enabled = true;
            }
        }

        #region 入库方式
        public void BtnStorageAdd(object sender, EventArgs e)
        {
            this.View.TxtStorageId.Text = "";
            this.View.TxtStorageName.Text = "";
            this.View.TxtStorageRemark.Text = "";
            this.View.CboStorageIfUse.Checked = true;
            this.View.TxtStorageName.Enabled = true;
            this.View.TxtStorageRemark.Enabled = true;
            this.View.CboStorageIfUse.Enabled = true;
            this.View.BtnStorageSave.Enabled = true;
            this.View.BtnStorageAdd.Enabled = false;
        }
        public void BtnStorageSave(object sender, EventArgs e)
        {
            StorageWayEntity swe = new StorageWayEntity()
            {
                SwaName = this.View.TxtStorageName.Text,
                SwaRemark = this.View.TxtStorageRemark.Text,
                SwaIfUse = this.View.CboStorageIfUse.Checked
            };
            if (this.View.TxtStorageId.Text != null && this.View.TxtStorageId.Text != "")
            {
                swe.SwaId = Convert.ToInt32(this.View.TxtStorageId.Text);
                string jsonresult= MyBaseMessageService.EditStorageWay(swe);
                FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                if (fi.ErrorStatus == STATUS_ADAPTER.SAVE_SUCCESS)
                {
                    LoadStorageWayData();
                    this.View.DgvStorage.Rows[storageRowIndex].Selected = true;
                    MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示");
                }
                else
                {
                    MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
                }
            }
            else
            {
                string result = CheckStorageName(swe.SwaName);
                if (result == "正确")
                {
                    string jsonresult = MyBaseMessageService.AddStorageWay(swe);
                    FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                    if (fi.ErrorStatus == STATUS_ADAPTER.INSERT_NORMAL)
                    {
                        LoadStorageWayData();
                        this.View.DgvStorage.Rows[this.View.DgvStorage.Rows.Count - 1].Selected = true;
                        MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示");
                    }
                    else
                    {
                        MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
                    }
                }
                else
                {
                    MsgBox.ShowDialog(result, "信息提示", MsgBox.MyButtons.OKCancel, true);
                }
            }
            this.View.TxtStorageName.Enabled = false;
            this.View.TxtStorageRemark.Enabled = false;
            this.View.CboStorageIfUse.Enabled = false;
            this.View.BtnStorageSave.Enabled = false;
            this.View.BtnStorageAdd.Enabled = true;
        }

        public string CheckStorageName(string name)
        {
            string result = "";
            if (name != null && name.Trim() != "")
            {
                string jsonresult = MyBaseMessageService.GetStorageWayByName(name);
                FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                if (fi.ErrorStatus == STATUS_ADAPTER.QUERY_NORMAL)
                {
                    if (fi.Result == null)
                    {
                        result = "正确";
                    }
                    else
                    {
                        result = "该名称已存在！";
                    }
                }
                else
                {
                    result = fi.FeedbackMessage;
                }
            }
            else
            {
                result = "名称不能为空！";
            }
            return result;
        }
        public void LoadStorageWayData()
        {
            string jsonresult = MyBaseMessageService.GetAllStorageWay();
            FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
            if (fi.ErrorStatus == STATUS_ADAPTER.QUERY_NORMAL)
            {
                List<StorageWayEntity> MySwes = JsonConvert.DeserializeObject<List<StorageWayEntity>>(fi.Result.ToString());
                this.View.SetStorageWayDataSource(MySwes);
            }
            else
            {
                MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
            }
        }
        public void StorageRowClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.View.DgvStorage.Rows[e.RowIndex];
                this.View.TxtStorageId.Text = row.Cells[0].Value.ToString();
                this.View.TxtStorageName.Text = row.Cells[1].Value.ToString();
                this.View.TxtStorageRemark.Text = row.Cells[2].Value.ToString();
                if (Convert.ToBoolean(row.Cells[3].Value) == true)
                {
                    this.View.CboStorageIfUse.Checked = true;
                }
                else
                {
                    this.View.CboStorageIfUse.Checked = false;
                }
            }
            storageRowIndex = e.RowIndex;
            this.View.TxtStorageName.Enabled = false;
            this.View.TxtStorageRemark.Enabled = false;
            this.View.CboStorageIfUse.Enabled = false;
            this.View.BtnStorageSave.Enabled = false;
            this.View.BtnStorageAdd.Enabled = true;
        }

        public void StorageRowDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.View.DgvStorage.Rows[e.RowIndex];
                this.View.TxtStorageId.Text = row.Cells[0].Value.ToString();
                this.View.TxtStorageName.Text = row.Cells[1].Value.ToString();
                this.View.TxtStorageRemark.Text = row.Cells[2].Value.ToString();
                if (Convert.ToBoolean(row.Cells[3].Value) == true)
                {
                    this.View.CboStorageIfUse.Checked = true;
                }
                else
                {
                    this.View.CboStorageIfUse.Checked = false;
                }
            }
            storageRowIndex = e.RowIndex;
            this.View.TxtStorageName.Enabled = false;
            this.View.TxtStorageRemark.Enabled = true;
            this.View.CboStorageIfUse.Enabled = true;
            this.View.BtnStorageSave.Enabled = true;
            this.View.BtnStorageAdd.Enabled = false;
        }

        private void DgvStorageRowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                this.View.DgvStorage.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                this.View.DgvStorage.RowHeadersDefaultCellStyle.Font,
                rectangle,
                this.View.DgvStorage.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        #endregion

        #region 出库方式
        public void BtnOutboundAdd(object sender, EventArgs e)
        {
            this.View.TxtOutboundId.Text = "";
            this.View.TxtOutboundName.Text = "";
            this.View.TxtOutboundRemark.Text = "";
            this.View.CboOutboundIfUse.Checked = true;
            this.View.TxtOutboundName.Enabled = true;
            this.View.TxtOutboundRemark.Enabled = true;
            this.View.CboOutboundIfUse.Enabled = true;
            this.View.BtnOutboundSave.Enabled = true;
            this.View.BtnOutboundAdd.Enabled = false;
        }
        public void BtnOutboundSave(object sender, EventArgs e)
        {
            OutboundWayEntity owe = new OutboundWayEntity()
            {
                OwaName = this.View.TxtOutboundName.Text,
                OwaRemark = this.View.TxtOutboundRemark.Text,
                OwaIfUse = this.View.CboOutboundIfUse.Checked
            };
            if (this.View.TxtOutboundId.Text != null && this.View.TxtOutboundId.Text != "")
            {
                owe.OwaId = Convert.ToInt32(this.View.TxtOutboundId.Text);
                string jsonresult = MyBaseMessageService.EditOutboundWay(owe);
                FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                if (fi.ErrorStatus == STATUS_ADAPTER.SAVE_SUCCESS)
                {
                    LoadOutboundWayData();
                    this.View.DgvOutbound.Rows[outboundRowIndex].Selected = true;
                    MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示");
                }
                else
                {
                    MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
                }
            }
            else
            {
                string result = CheckOutboundName(owe.OwaName);
                if (result == "正确")
                {
                    string jsonresult = MyBaseMessageService.AddOutboundWay(owe);
                    FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                    if (fi.ErrorStatus == STATUS_ADAPTER.INSERT_NORMAL)
                    {
                        LoadOutboundWayData();
                        this.View.DgvOutbound.Rows[this.View.DgvOutbound.Rows.Count - 1].Selected = true;
                        MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示");
                    }
                    else
                    {
                        MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
                    }
                }
                else
                {
                    MsgBox.ShowDialog(result, "信息提示", MsgBox.MyButtons.OKCancel, true);
                }
            }
            this.View.TxtOutboundName.Enabled = false;
            this.View.TxtOutboundRemark.Enabled = false;
            this.View.CboOutboundIfUse.Enabled = false;
            this.View.BtnOutboundSave.Enabled = false;
            this.View.BtnOutboundAdd.Enabled = true;
        }
        public string CheckOutboundName(string name)
        {
            string result = "";
            if (name != null && name.Trim() != "")
            {
                string jsonresult = MyBaseMessageService.GetOutboundWayByName(name);
                FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                if (fi.ErrorStatus == STATUS_ADAPTER.QUERY_NORMAL)
                {
                    if (fi.Result == null)
                    {
                        result = "正确";
                    }
                    else
                    {
                        result = "该名称已存在！";
                    }
                }
                else
                {
                    result = fi.FeedbackMessage;
                }
            }
            else
            {
                result = "名称不能为空！";
            }
            return result;
        }
        public void LoadOutboundWayData()
        {
            string jsonresult = MyBaseMessageService.GetAllOutboundWay();
            FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
            if (fi.ErrorStatus == STATUS_ADAPTER.QUERY_NORMAL)
            {
                List<OutboundWayEntity> MyOwes = JsonConvert.DeserializeObject<List<OutboundWayEntity>>(fi.Result.ToString());
                this.View.SetOutboundDataSource(MyOwes);
            }
            else
            {
                MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
            }
        }
        public void OutboundRowClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.View.DgvOutbound.Rows[e.RowIndex];
                this.View.TxtOutboundId.Text = row.Cells[0].Value.ToString();
                this.View.TxtOutboundName.Text = row.Cells[1].Value.ToString();
                this.View.TxtOutboundRemark.Text = row.Cells[2].Value.ToString();
                if (Convert.ToBoolean(row.Cells[3].Value) == true)
                {
                    this.View.CboOutboundIfUse.Checked = true;
                }
                else
                {
                    this.View.CboOutboundIfUse.Checked = false;
                }
            }
            outboundRowIndex = e.RowIndex;
            this.View.TxtOutboundName.Enabled = false;
            this.View.TxtOutboundRemark.Enabled = false;
            this.View.CboOutboundIfUse.Enabled = false;
            this.View.BtnOutboundSave.Enabled = false;
            this.View.BtnOutboundAdd.Enabled = true;
        }

        public void OutboundRowDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.View.DgvOutbound.Rows[e.RowIndex];
                this.View.TxtOutboundId.Text = row.Cells[0].Value.ToString();
                this.View.TxtOutboundName.Text = row.Cells[1].Value.ToString();
                this.View.TxtOutboundRemark.Text = row.Cells[2].Value.ToString();
                if (Convert.ToBoolean(row.Cells[3].Value) == true)
                {
                    this.View.CboOutboundIfUse.Checked = true;
                }
                else
                {
                    this.View.CboOutboundIfUse.Checked = false;
                }
            }
            outboundRowIndex = e.RowIndex;
            this.View.TxtOutboundName.Enabled = false;
            this.View.TxtOutboundRemark.Enabled = true;
            this.View.CboOutboundIfUse.Enabled = true;
            this.View.BtnOutboundSave.Enabled = true;
            this.View.BtnOutboundAdd.Enabled = false;
        }

        private void DgvOutboundRowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                this.View.DgvOutbound.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                this.View.DgvOutbound.RowHeadersDefaultCellStyle.Font,
                rectangle,
                this.View.DgvOutbound.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        #endregion

        #region 计量方式
        public void BtnMeasureAdd(object sender, EventArgs e)
        {
            this.View.TxtMeasureId.Text = "";
            this.View.TxtMeasureName.Text = "";
            this.View.TxtMeasureRemark.Text = "";
            this.View.CboMeasureIfUse.Checked = true;
            this.View.TxtMeasureName.Enabled = true;
            this.View.TxtMeasureRemark.Enabled = true;
            this.View.CboMeasureIfUse.Enabled = true;
            this.View.BtnMeasureSave.Enabled = true;
            this.View.BtnMeasureAdd.Enabled = false;
        }
        public void BtnMeasureSave(object sender, EventArgs e)
        {
            MeasureWayEntity mwe = new MeasureWayEntity()
            {
                MwaName = this.View.TxtMeasureName.Text,
                MwaRemark = this.View.TxtMeasureRemark.Text,
                MwaIfUse = this.View.CboMeasureIfUse.Checked
            };
            if (this.View.TxtMeasureId.Text != null && this.View.TxtMeasureId.Text != "")
            {
                mwe.MwaId = Convert.ToInt32(this.View.TxtMeasureId.Text);
                string jsonresult = MyBaseMessageService.EditMeasureWay(mwe);
                FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                if (fi.ErrorStatus == STATUS_ADAPTER.SAVE_SUCCESS)
                {
                    LoadMeasureWayData();
                    this.View.DgvMeasure.Rows[measureRowIndex].Selected = true;
                    MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示");
                }
                else
                {
                    MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
                } 
            }
            else
            {
                string result = CheckMeasureName(mwe.MwaName);
                if (result == "正确")
                {
                    string jsonresult = MyBaseMessageService.AddMeasureWay(mwe);
                    FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                    if (fi.ErrorStatus == STATUS_ADAPTER.INSERT_NORMAL)
                    {
                        LoadMeasureWayData();
                        this.View.DgvMeasure.Rows[this.View.DgvMeasure.Rows.Count - 1].Selected = true;
                        MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示");
                    }
                    else
                    {
                        MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
                    }
                }
                else
                {
                    MsgBox.ShowDialog(result, "信息提示", MsgBox.MyButtons.OKCancel, true);
                }
            }
            this.View.TxtMeasureName.Enabled = false;
            this.View.TxtMeasureRemark.Enabled = false;
            this.View.CboMeasureIfUse.Enabled = false;
            this.View.BtnMeasureSave.Enabled = false;
            this.View.BtnMeasureAdd.Enabled = true;
        }

        public string CheckMeasureName(string name)
        {
            string result = "";
            if (name != null && name.Trim() != "")
            {
                string jsonresult = MyBaseMessageService.GetMeasureWayByName(name);
                FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                if (fi.ErrorStatus == STATUS_ADAPTER.QUERY_NORMAL)
                {
                    if (fi.Result == null)
                    {
                        result = "正确";
                    }
                    else
                    {
                        result = "该名称已存在！";
                    }
                }
                else
                {
                    result = fi.FeedbackMessage;
                }
            }
            else
            {
                result = "名称不能为空！";
            }
            return result;
        }
        public void LoadMeasureWayData()
        {
            string jsonresult = MyBaseMessageService.GetAllMeasureWay();
            FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
            if (fi.ErrorStatus == STATUS_ADAPTER.QUERY_NORMAL)
            {
                List<MeasureWayEntity> MyMwes = JsonConvert.DeserializeObject<List<MeasureWayEntity>>(fi.Result.ToString());
                this.View.SetMeasureDataSource(MyMwes);
            }
            else
            {
                MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
            }
        }
        public void MeasureRowClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.View.DgvMeasure.Rows[e.RowIndex];
                this.View.TxtMeasureId.Text = row.Cells[0].Value.ToString();
                this.View.TxtMeasureName.Text = row.Cells[1].Value.ToString();
                this.View.TxtMeasureRemark.Text = row.Cells[2].Value.ToString();
                if (Convert.ToBoolean(row.Cells[3].Value) == true)
                {
                    this.View.CboMeasureIfUse.Checked = true;
                }
                else
                {
                    this.View.CboMeasureIfUse.Checked = false;
                }
            }
            measureRowIndex = e.RowIndex;
            this.View.TxtMeasureName.Enabled = false;
            this.View.TxtMeasureRemark.Enabled = false;
            this.View.CboMeasureIfUse.Enabled = false;
            this.View.BtnMeasureSave.Enabled = false;
            this.View.BtnMeasureAdd.Enabled = true;
        }

        public void MeasureRowDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.View.DgvMeasure.Rows[e.RowIndex];
                this.View.TxtMeasureId.Text = row.Cells[0].Value.ToString();
                this.View.TxtMeasureName.Text = row.Cells[1].Value.ToString();
                this.View.TxtMeasureRemark.Text = row.Cells[2].Value.ToString();
                if (Convert.ToBoolean(row.Cells[3].Value) == true)
                {
                    this.View.CboMeasureIfUse.Checked = true;
                }
                else
                {
                    this.View.CboMeasureIfUse.Checked = false;
                }
            }
            measureRowIndex = e.RowIndex;
            this.View.TxtMeasureName.Enabled = false;
            this.View.TxtMeasureRemark.Enabled = true;
            this.View.CboMeasureIfUse.Enabled = true;
            this.View.BtnMeasureSave.Enabled = true;
            this.View.BtnMeasureAdd.Enabled = false;
        }

        private void DgvMeasureRowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                this.View.DgvMeasure.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                this.View.DgvMeasure.RowHeadersDefaultCellStyle.Font,
                rectangle,
                this.View.DgvMeasure.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        #endregion

        #region 货场属性
        public void BtnDepotsAdd(object sender, EventArgs e)
        {
            this.View.TxtDepotsId.Text = "";
            this.View.TxtDepotsName.Text = "";
            this.View.TxtDepotsRemark.Text = "";
            this.View.CboDepotsIfUse.Checked = true;
            this.View.TxtDepotsName.Enabled = true;
            this.View.TxtDepotsRemark.Enabled = true;
            this.View.CboDepotsIfUse.Enabled = true;
            this.View.BtnDepotsSave.Enabled = true;
            this.View.BtnDepotsAdd.Enabled = false;
        }
        public void BtnDepotsSave(object sender, EventArgs e)
        {
            DepotsPropertyEntity dpe = new DepotsPropertyEntity()
            {
                DprName = this.View.TxtDepotsName.Text,
                DprRemark = this.View.TxtDepotsRemark.Text,
                DprIfUse = this.View.CboDepotsIfUse.Checked
            };
            if (this.View.TxtDepotsId.Text != null && this.View.TxtDepotsId.Text != "")
            {
                dpe.DprId = Convert.ToInt32(this.View.TxtDepotsId.Text);
                string jsonresult = MyBaseMessageService.EditDepotsProperty(dpe);
                FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                if (fi.ErrorStatus == STATUS_ADAPTER.SAVE_SUCCESS)
                {
                    LoadDepotsPropertyData();
                    this.View.DgvDepots.Rows[depotsRowIndex].Selected = true;
                    MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示");
                }
                else
                {
                    MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
                }
            }
            else
            {
                string result = CheckDepotsName(dpe.DprName);
                if (result == "正确")
                {
                    string jsonresult = MyBaseMessageService.AddDepotsProperty(dpe);
                    FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                    if (fi.ErrorStatus == STATUS_ADAPTER.INSERT_NORMAL)
                    {
                        LoadDepotsPropertyData();
                        this.View.DgvDepots.Rows[this.View.DgvDepots.Rows.Count - 1].Selected = true;
                        MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示");
                    }
                    else
                    {
                        MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
                    }
                }
                else
                {
                    MsgBox.ShowDialog(result, "信息提示", MsgBox.MyButtons.OKCancel, true);
                }
            }
            this.View.TxtDepotsName.Enabled = false;
            this.View.TxtDepotsRemark.Enabled = false;
            this.View.CboDepotsIfUse.Enabled = false;
            this.View.BtnDepotsSave.Enabled = false;
            this.View.BtnDepotsAdd.Enabled = true;
        }
        public string CheckDepotsName(string name)
        {
            string result = "";
            if (name != null && name.Trim() != "")
            {
                string jsonresult = MyBaseMessageService.GetDepotsPropertyByName(name);
                FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                if (fi.ErrorStatus == STATUS_ADAPTER.QUERY_NORMAL)
                {
                    if (fi.Result == null)
                    {
                        result = "正确";
                    }
                    else
                    {
                        result = "该名称已存在！";
                    }
                }
                else
                {
                    result = fi.FeedbackMessage;
                }
            }
            else
            {
                result = "名称不能为空！";
            }
            return result;
        }
        public void LoadDepotsPropertyData()
        {
            string jsonresult = MyBaseMessageService.GetAllDepotsProperty();
            FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
            if (fi.ErrorStatus == STATUS_ADAPTER.QUERY_NORMAL)
            {
                List<DepotsPropertyEntity> MyDpes = JsonConvert.DeserializeObject<List<DepotsPropertyEntity>>(fi.Result.ToString());
                this.View.SetDepotsDataSource(MyDpes);
            }
            else
            {
                MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
            }
        }
        public void DepotsRowClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.View.DgvDepots.Rows[e.RowIndex];
                this.View.TxtDepotsId.Text = row.Cells[0].Value.ToString();
                this.View.TxtDepotsName.Text = row.Cells[1].Value.ToString();
                this.View.TxtDepotsRemark.Text = row.Cells[2].Value.ToString();
                if (Convert.ToBoolean(row.Cells[3].Value) == true)
                {
                    this.View.CboDepotsIfUse.Checked = true;
                }
                else
                {
                    this.View.CboDepotsIfUse.Checked = false;
                }
            }
            depotsRowIndex = e.RowIndex;
            this.View.TxtDepotsName.Enabled = false;
            this.View.TxtDepotsRemark.Enabled = false;
            this.View.CboDepotsIfUse.Enabled = false;
            this.View.BtnDepotsSave.Enabled = false;
            this.View.BtnDepotsAdd.Enabled = true;
        }

        public void DepotsRowDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.View.DgvDepots.Rows[e.RowIndex];
                this.View.TxtDepotsId.Text = row.Cells[0].Value.ToString();
                this.View.TxtDepotsName.Text = row.Cells[1].Value.ToString();
                this.View.TxtDepotsRemark.Text = row.Cells[2].Value.ToString();
                if (Convert.ToBoolean(row.Cells[3].Value) == true)
                {
                    this.View.CboDepotsIfUse.Checked = true;
                }
                else
                {
                    this.View.CboDepotsIfUse.Checked = false;
                }
            }
            depotsRowIndex = e.RowIndex;
            this.View.TxtDepotsName.Enabled = false;
            this.View.TxtDepotsRemark.Enabled = true;
            this.View.CboDepotsIfUse.Enabled = true;
            this.View.BtnDepotsSave.Enabled = true;
            this.View.BtnDepotsAdd.Enabled = false;
        }

        private void DgvDepotsRowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                this.View.DgvDepots.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                this.View.DgvDepots.RowHeadersDefaultCellStyle.Font,
                rectangle,
                this.View.DgvDepots.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        #endregion

        #region 费率类型
        public void BtnRateTypeAdd(object sender, EventArgs e)
        {
            this.View.TxtRateTypeId.Text = "";
            this.View.TxtRateTypeName.Text = "";
            this.View.TxtRateTypeRemark.Text = "";
            this.View.CboRateTypeIfUse.Checked = true;
            this.View.TxtRateTypeName.Enabled = true;
            this.View.TxtRateTypeRemark.Enabled = true;
            this.View.CboRateTypeIfUse.Enabled = true;
            this.View.BtnRateTypeSave.Enabled = true;
            this.View.BtnRateTypeAdd.Enabled = false;
        }
        public void BtnRateTypeSave(object sender, EventArgs e)
        {
            RateTypeEntity rte = new RateTypeEntity()
            {
                RtyName = this.View.TxtRateTypeName.Text,
                RtyRemark = this.View.TxtRateTypeRemark.Text,
                RtyIfUse = this.View.CboRateTypeIfUse.Checked
            };
            if (this.View.TxtRateTypeId.Text != null && this.View.TxtRateTypeId.Text != "")
            {
                rte.RtyId = Convert.ToInt32(this.View.TxtRateTypeId.Text);
                string jsonresult = MyBaseMessageService.EditRateType(rte);
                FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                if (fi.ErrorStatus == STATUS_ADAPTER.SAVE_SUCCESS)
                {
                    LoadRateTypeData();
                    this.View.DgvRateType.Rows[rateTypeRowIndex].Selected = true;
                    MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示");
                }
                else
                {
                    MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
                } 
            }
            else
            {
                string result = CheckRateTypeName(rte.RtyName);
                if (result == "正确")
                {
                    string jsonresult = MyBaseMessageService.AddRateType(rte);
                    FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                    if (fi.ErrorStatus == STATUS_ADAPTER.INSERT_NORMAL)
                    {
                        LoadRateTypeData();
                        this.View.DgvRateType.Rows[this.View.DgvRateType.Rows.Count - 1].Selected = true;
                        MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示");
                    }
                    else
                    {
                        MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
                    }
                }
                else
                {
                    MsgBox.ShowDialog(result, "信息提示", MsgBox.MyButtons.OKCancel, true);
                }
            }
            this.View.TxtRateTypeName.Enabled = false;
            this.View.TxtRateTypeRemark.Enabled = false;
            this.View.CboRateTypeIfUse.Enabled = false;
            this.View.BtnRateTypeSave.Enabled = false;
            this.View.BtnRateTypeAdd.Enabled = true;
        }

        public string CheckRateTypeName(string name)
        {
            string result = "";
            if (name != null && name.Trim() != "")
            {
                string jsonresult = MyBaseMessageService.GetRateTypeByName(name);
                FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
                if (fi.ErrorStatus == STATUS_ADAPTER.QUERY_NORMAL)
                {
                    if (fi.Result == null)
                    {
                        result = "正确";
                    }
                    else
                    {
                        result = "该名称已存在！";
                    }
                }
                else
                {
                    result = fi.FeedbackMessage;
                }
            }
            else
            {
                result = "名称不能为空！";
            }
            return result;
        }
        public void LoadRateTypeData()
        {
            string jsonresult = MyBaseMessageService.GetAllRateType();
            FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
            if (fi.ErrorStatus == STATUS_ADAPTER.QUERY_NORMAL)
            {
                List<RateTypeEntity> MyRtes = JsonConvert.DeserializeObject<List<RateTypeEntity>>(fi.Result.ToString());
                this.View.SetRateTypeDataSource(MyRtes);
            }
            else
            {
                MsgBox.ShowDialog(fi.FeedbackMessage, "信息提示", MsgBox.MyButtons.OKCancel, true);
            }
        }
        public void RateTypeRowClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.View.DgvRateType.Rows[e.RowIndex];
                this.View.TxtRateTypeId.Text = row.Cells[0].Value.ToString();
                this.View.TxtRateTypeName.Text = row.Cells[1].Value.ToString();
                this.View.TxtRateTypeRemark.Text = row.Cells[2].Value.ToString();
                if (Convert.ToBoolean(row.Cells[3].Value) == true)
                {
                    this.View.CboRateTypeIfUse.Checked = true;
                }
                else
                {
                    this.View.CboRateTypeIfUse.Checked = false;
                }
            }
            rateTypeRowIndex = e.RowIndex;
            this.View.TxtRateTypeName.Enabled = false;
            this.View.TxtRateTypeRemark.Enabled = false;
            this.View.CboRateTypeIfUse.Enabled = false;
            this.View.BtnRateTypeSave.Enabled = false;
            this.View.BtnRateTypeAdd.Enabled = true;
        }

        public void RateTypeRowDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.View.DgvRateType.Rows[e.RowIndex];
                this.View.TxtRateTypeId.Text = row.Cells[0].Value.ToString();
                this.View.TxtRateTypeName.Text = row.Cells[1].Value.ToString();
                this.View.TxtRateTypeRemark.Text = row.Cells[2].Value.ToString();
                if (Convert.ToBoolean(row.Cells[3].Value) == true)
                {
                    this.View.CboRateTypeIfUse.Checked = true;
                }
                else
                {
                    this.View.CboRateTypeIfUse.Checked = false;
                }
            }
            rateTypeRowIndex = e.RowIndex;
            this.View.TxtRateTypeName.Enabled = false;
            this.View.TxtRateTypeRemark.Enabled = true;
            this.View.CboRateTypeIfUse.Enabled = true;
            this.View.BtnRateTypeSave.Enabled = true;
            this.View.BtnRateTypeAdd.Enabled = false;
        }

        private void DgvRateTypeRowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                this.View.DgvRateType.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                this.View.DgvRateType.RowHeadersDefaultCellStyle.Font,
                rectangle,
                this.View.DgvRateType.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        #endregion
    }
}
