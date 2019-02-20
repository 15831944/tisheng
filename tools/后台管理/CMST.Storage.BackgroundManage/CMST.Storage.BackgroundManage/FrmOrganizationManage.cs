using CMST.Storage.BackgroundManage.BLL;
using CMST.Storage.BackgroundManage.Common;
using CMST.Storage.BackgroundManage.DAL;
using CMST.Storage.BackgroundManage.Data;
using CMST.Storage.BackgroundManage.Service;
using CMSTMsgBox;
using Newtonsoft.Json;
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
    public partial class FrmOrganizationManage : Form
    {
        OrganizationService MyOrganizationService = new OrganizationService();
        private List<OrganizationEntity> oes = new List<OrganizationEntity>();
        public FrmOrganizationManage()
        {
            InitializeComponent();
            this.btnSaveCmst.Enabled = false;
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string jsonresult = MyOrganizationService.GetAllOrganization();
            FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
            if (fi.ErrorStatus == STATUS_ADAPTER.SAVE_SUCCESS)
            {
                oes = JsonConvert.DeserializeObject<List<OrganizationEntity>>(fi.Result.ToString());
                this.dgvOrganization.DataSource = oes;        
            }
            else
            {
                MsgBox.ShowDialog(fi.FeedbackMessage);
            }
                 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtcode.Text.Trim()==""||this.txtName.Text.Trim()==""||this.txtSysAccount.Text.Trim()=="")
            {
                MsgBox.ShowDialog("帐套编号，名称不能为空！！！");
                return;
            }
            OrganizationEntity oe = new OrganizationEntity();
            SetOrganization(oe);
            string jsonresult = MyOrganizationService.SaveOrganization(oe);
            FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
            if (fi.ErrorStatus == STATUS_ADAPTER.SAVE_SUCCESS)
            {         
                    MsgBox.ShowDialog("保存成功！！！");
                    this.btnSaveCmst.Enabled = false;  
            }
            else
            {
                MsgBox.ShowDialog(fi.FeedbackMessage);
            }
        }
        private void SetOrganization(OrganizationEntity oe)
        {
            oe.CmstID = int.Parse(this.txtcode.Text.Trim());
            oe.CmstName = this.txtName.Text;
            oe.CmstIfUse = this.cbIfUse.Checked;
            oe.CmstSysAccount = this.txtSysAccount.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.btnSaveCmst.Enabled = true;
            this.txtcode.Text = "";
            this.txtName.Text = "";
            this.txtSysAccount.Text = "";
            this.cbIfUse.Checked = false;
            this.cbIfUse.Enabled = true;
            this.txtcode.Enabled = true;
            this.txtName.Enabled = true;
            this.txtSysAccount.Enabled = true;
        }

        private void dgvOrganization_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = this.dgvOrganization.Rows[e.RowIndex];
                this.txtcode.Text = row.Cells[0].Value.ToString();
                this.txtName.Text = row.Cells[1].Value.ToString();
                this.txtSysAccount.Text= row.Cells[2].Value.ToString();
                if (Boolean.Parse(row.Cells[3].Value.ToString()) == true)
                {
                    
                    this.cbIfUse.Checked = true;
                }
                else
                {
                    this.cbIfUse.Checked = false;
                }
            }
            this.btnSaveCmst.Enabled = false;
            this.txtcode.Enabled = false;
            this.txtName.Enabled = false;
            this.txtSysAccount.Enabled = false;
            this.cbIfUse.Enabled = false;
        }

    }
}
