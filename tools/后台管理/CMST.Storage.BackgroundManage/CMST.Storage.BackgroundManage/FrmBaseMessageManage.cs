using CMST.Storage.BackgroundManage.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMST.Storage.BackgroundManage
{
    public partial class FrmBaseMessageManage : Form
    {
        public FrmBaseMessageManage()
        {
            InitializeComponent();
        }
        public TabControl TcBaseMessage
        {
            get { return this.tcBaseMessage; }
        }

        #region 入库方式
        public DataGridView DgvStorage
        {
            get { return this.dgvStorage; }
        }
        public TextBox TxtStorageName
        {
            get { return this.txtStorageName; }
        }
        public TextBox TxtStorageId
        {
            get { return this.txtStorageId; }
        }
        public TextBox TxtStorageRemark
        {
            get { return this.txtStorageRemark; }
        }
        public CheckBox CboStorageIfUse
        {
            get { return this.cboStorageIfUse; }
        }
        public Button BtnStorageAdd
        {
            get { return this.btnStorageAdd; }
        }
        public Button BtnStorageSave
        {
            get { return this.btnStorageSave; }
        }
        public void SetStorageWayDataSource(List<StorageWayEntity> swes)
        {
            dgvStorage.AutoGenerateColumns = false;
            dgvStorage.DataSource = swes;
        }
        #endregion

        #region 出库方式
        public DataGridView DgvOutbound
        {
            get { return this.dgvOutbound; }
        }
        public TextBox TxtOutboundName
        {
            get { return this.txtOutboundName; }
        }
        public TextBox TxtOutboundId
        {
            get { return this.txtOutboundId; }
        }
        public TextBox TxtOutboundRemark
        {
            get { return this.txtOutboundRemark; }
        }
        public CheckBox CboOutboundIfUse
        {
            get { return this.cboOutboundIfUse; }
        }
        public Button BtnOutboundAdd
        {
            get { return this.btnOutboundAdd; }
        }
        public Button BtnOutboundSave
        {
            get { return this.btnOutboundSave; }
        }
        public void SetOutboundDataSource(List<OutboundWayEntity> owes)
        {
            dgvOutbound.AutoGenerateColumns = false;
            dgvOutbound.DataSource = owes;
        }
        #endregion

        #region 计量方式
        public DataGridView DgvMeasure
        {
            get { return this.dgvMeasure; }
        }
        public TextBox TxtMeasureName
        {
            get { return this.txtMeasureName; }
        }
        public TextBox TxtMeasureId
        {
            get { return this.txtMeasureId; }
        }
        public TextBox TxtMeasureRemark
        {
            get { return this.txtMeasureRemark; }
        }
        public CheckBox CboMeasureIfUse
        {
            get { return this.cboMeasureIfUse; }
        }
        public Button BtnMeasureAdd
        {
            get { return this.btnMeasureAdd; }
        }
        public Button BtnMeasureSave
        {
            get { return this.btnMeasureSave; }
        }
        public void SetMeasureDataSource(List<MeasureWayEntity> mwes)
        {
            dgvMeasure.AutoGenerateColumns = false;
            dgvMeasure.DataSource = mwes;
        }
        #endregion

        #region 货场属性
        public DataGridView DgvDepots
        {
            get { return this.dgvDepots; }
        }
        public TextBox TxtDepotsName
        {
            get { return this.txtDepotsName; }
        }
        public TextBox TxtDepotsId
        {
            get { return this.txtDepotsId; }
        }
        public TextBox TxtDepotsRemark
        {
            get { return this.txtDepotsRemark; }
        }
        public CheckBox CboDepotsIfUse
        {
            get { return this.cboDepotsIfUse; }
        }
        public Button BtnDepotsAdd
        {
            get { return this.btnDepotsAdd; }
        }
        public Button BtnDepotsSave
        {
            get { return this.btnDepotsSave; }
        }
        public void SetDepotsDataSource(List<DepotsPropertyEntity> dpes)
        {
            dgvDepots.AutoGenerateColumns = false;
            dgvDepots.DataSource = dpes;
        }
        #endregion

        #region 费率类型
        public DataGridView DgvRateType
        {
            get { return this.dgvRateType; }
        }
        public TextBox TxtRateTypeName
        {
            get { return this.txtRateTypeName; }
        }
        public TextBox TxtRateTypeId
        {
            get { return this.txtRateTypeId; }
        }
        public TextBox TxtRateTypeRemark
        {
            get { return this.txtRateTypeRemark; }
        }
        public CheckBox CboRateTypeIfUse
        {
            get { return this.cboRateTypeIfUse; }
        }
        public Button BtnRateTypeAdd
        {
            get { return this.btnRateTypeAdd; }
        }
        public Button BtnRateTypeSave
        {
            get { return this.btnRateTypeSave; }
        }
        public void SetRateTypeDataSource(List<RateTypeEntity> rtes)
        {
            dgvRateType.AutoGenerateColumns = false;
            dgvRateType.DataSource = rtes;
        }
        #endregion

    }
}
