using CMST.Storage.BackgroundManage.Common;
using CMST.Storage.BackgroundManage.Data;
using CMST.Storage.BackgroundManage.Service;
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
    public partial class FrmAuthorityManage : Form
    {
        private int tempMenuID;
        private int tempRank;
        private TreeNode tempNode;
        private DataSet dsope;
        MenuEntity me = new MenuEntity();
        OperationEntity oe = new OperationEntity();
        MenuManageService MyMenuManageService = new MenuManageService();
        OperationManageService MyOperationManageService = new OperationManageService();
        public FrmAuthorityManage()
        {
            InitializeComponent();
            this.btnSave.Enabled = false;
            this.btnSaveOperate.Enabled = false;
            LoadMenuData();
            
        }
        
        private void LoadMenuData()
        {
            this.tvMenu.Nodes.Clear();
            string jsonresult = MyMenuManageService.GetAllMenu();
            FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
            if (fi.ErrorStatus == STATUS_ADAPTER.SAVE_SUCCESS)
            {
                DataSet ds = JsonConvert.DeserializeObject<DataSet>(fi.Result.ToString());
                DataRow[] drs = ds.Tables[0].Select("Meu_FatherMenuID = 0");
                foreach (DataRow dr in drs)
                {
                    TreeNode tn = new TreeNode();
                    tn.Text = dr["Meu_Menu"].ToString();
                    tn.Tag = Convert.ToInt32(dr["Meu_ID"]);
                    this.tvMenu.Nodes.Add(tn);
                    CreatSubMenu(tn, dr);
                }
            }
            else
            {
                CMSTMsgBox.MsgBox.ShowDialog(fi.FeedbackMessage);
            }
        }
        private void LoadOperateData()
        {
            this.tvOperate.Nodes.Clear();
            string jsonresult = MyMenuManageService.GetAllMenu();
            FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
            string jsonresult1 = MyOperationManageService.GetAllOperation();
            FeedbackInfomation fi1 = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult1);
            if (fi.ErrorStatus == STATUS_ADAPTER.SAVE_SUCCESS)
            {
                DataSet ds = JsonConvert.DeserializeObject<DataSet>(fi.Result.ToString());
                if (fi1.Result!=null)
                {
                    dsope = JsonConvert.DeserializeObject<DataSet>(fi1.Result.ToString());
                }                
                DataRow[] drs = ds.Tables[0].Select("Meu_FatherMenuID = 0");
                foreach (DataRow dr in drs)
                {
                    TreeNode tn = new TreeNode();
                    tn.Text = dr["Meu_Menu"].ToString();
                    tn.Tag = Convert.ToInt32(dr["Meu_ID"]);
                    this.tvOperate.Nodes.Add(tn);
                    CreatSubMenu1(tn, dr);
                    CreatOperation(tn, dr);
                  
                }
            }
            else
            {
                CMSTMsgBox.MsgBox.ShowDialog(fi.FeedbackMessage);
            }
        }
        private void CreatSubMenu(TreeNode tn, DataRow dr)
        {
            DataRow[] drrs = dr.Table.Select("Meu_FatherMenuID = " + Convert.ToInt32(tn.Tag));
            foreach (DataRow drr in drrs)
            {
                TreeNode tnn = new TreeNode();
                tnn.Text = drr["Meu_Menu"].ToString();
                tnn.Tag = Convert.ToInt32(drr["Meu_ID"]);
                tn.Nodes.Add(tnn);
                CreatSubMenu(tnn, drr);
            }

        }
        private void CreatSubMenu1(TreeNode tn, DataRow dr)
        {
            DataRow[] drrs = dr.Table.Select("Meu_FatherMenuID = " + Convert.ToInt32(tn.Tag));
            foreach (DataRow drr in drrs)
            {
                TreeNode tnn = new TreeNode();
                tnn.Text = drr["Meu_Menu"].ToString();
                tnn.Tag = Convert.ToInt32(drr["Meu_ID"]);
                tn.Nodes.Add(tnn);
                CreatSubMenu1(tnn, drr);
                CreatOperation(tnn, drr);
            }

        }
        private void CreatOperation(TreeNode tn, DataRow dr)
        {
            if (dsope!=null)
            {
                DataRow[] dropes = dsope.Tables[0].Select("Ope_Meu_ID=" + tn.Tag);
                if (dropes != null || dropes.Length != 0)
                {
                    foreach (DataRow drope in dropes)
                    {
                        TreeNode tnope = new TreeNode();
                        tnope.Text = drope["Ope_Name"].ToString();
                        tnope.Tag = Convert.ToInt32(drope["Ope_ID"]);
                        tnope.ForeColor = Color.Green;
                        tn.Nodes.Add(tnope);
                    }
                }
            }
           
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtMenuName.Text=="")
            {
                CMSTMsgBox.MsgBox.ShowDialog("菜单名称不能为空！！！");
                return;
            }
            SetMenu();
            string jsonresult = MyMenuManageService.SaveMenu(me);
            FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
            if (fi.ErrorStatus == STATUS_ADAPTER.SAVE_SUCCESS)
            {
                int ret = JsonConvert.DeserializeObject<int>(fi.Result.ToString());
                if (ret > 0)
                {
                    CMSTMsgBox.MsgBox.ShowDialog("保存成功！！！");
                    this.btnSave.Enabled = true;
                    ClearMenuInfo();
                    LoadMenuData();
                }
            }
            else
            {
                CMSTMsgBox.MsgBox.ShowDialog(fi.FeedbackMessage);
            }
        }

        private void btnAddFather_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
            if (this.tvMenu.Nodes.Count == 0)
            {
                this.txtFatherMenu.Text = Convert.ToString(0);
                this.txtRank.Text = Convert.ToString(1);
            }
            else
            {
                if (JudgetvMenuSelected())
                {
                    CMSTMsgBox.MsgBox.ShowDialog("请选择菜单!!!");
                    return;
                }
                tempMenuID = 0;
                if (this.tvMenu.SelectedNode.Parent != null)
                {
                    tempMenuID = Convert.ToInt32(this.tvMenu.SelectedNode.Parent.Tag);
                }
                tempRank = this.tvMenu.SelectedNode.Level + 1;
                this.txtFatherMenu.Text = tempMenuID.ToString();
                this.txtRank.Text = tempRank.ToString();
            }
        }
        private void btnAddSub_Click(object sender, EventArgs e)
        {
            if (this.tvMenu.Nodes.Count != 0)
            {
                if (JudgetvMenuSelected())
                {
                    CMSTMsgBox.MsgBox.ShowDialog("请选择菜单!!!");
                    return;
                }
                this.btnSave.Enabled = true;
                tempMenuID = Convert.ToInt32(this.tvMenu.SelectedNode.Tag);
                tempRank = this.tvMenu.SelectedNode.Level + 1;
                this.txtFatherMenu.Text = tempMenuID.ToString();
                this.txtRank.Text = (tempRank + 1).ToString();
            }
        }
        private void SetMenu()
        {
            me.CsyID = 1;
            me.MenuName = this.txtMenuName.Text;
            me.FatherID = int.Parse(this.txtFatherMenu.Text);
            me.Rank = int.Parse(this.txtRank.Text);
            me.Url = this.txtUrl.Text;
        }
        private void ClearMenuInfo()
        {
            this.txtFatherMenu.Text = "";
            this.txtMenuName.Text = "";
            this.txtRank.Text = "";
            this.txtUrl.Text = "";
            this.tvMenu.Nodes.Clear();
        }
        private bool JudgetvMenuSelected()
        {
            if (this.tvMenu.SelectedNode == null)
            {
                return true;
            }
            return false;
        }

        private void tabAuthorityManage_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.tabAuthorityManage.SelectedTab.Name == "tabMenu")
            {
                LoadMenuData();
            }
            if (this.tabAuthorityManage.SelectedTab.Name == "tabOperate")
            {
                LoadOperateData();
            }
        }
         private void SetOperation()
        {
            oe.CsyID = 1;
            oe.OperateName= this.txtOperateName.Text;
            oe.MenuID= int.Parse(this.txtMenu.Text);
            oe.OperateUrl = this.txtOperateUrl.Text;
        }
        private void ClearOperationInfo()
        {
            this.txtOperateName.Text = "";
            this.txtMenu.Text = "";
            this.txtOperateUrl.Text = "";
            this.tvOperate.Nodes.Clear();
        }
        private void btnSaveOperate_Click(object sender, EventArgs e)
        {
            if (this.txtOperateName.Text == "")
            {
                CMSTMsgBox.MsgBox.ShowDialog("操作名称不能为空！！！");
                return;
            }
            SetOperation();
            string jsonresult = MyOperationManageService.SaveOperation(oe);
            FeedbackInfomation fi = JsonConvert.DeserializeObject<FeedbackInfomation>(jsonresult);
            if (fi.ErrorStatus == STATUS_ADAPTER.SAVE_SUCCESS)
            {
                int ret = JsonConvert.DeserializeObject<int>(fi.Result.ToString());
                if (ret > 0)
                {
                    CMSTMsgBox.MsgBox.ShowDialog("保存成功！！！");
                    ClearOperationInfo();
                    LoadOperateData();
                }
            }
            else
            {
                CMSTMsgBox.MsgBox.ShowDialog(fi.FeedbackMessage);
            }
        }

        private void btnAddOperate_Click(object sender, EventArgs e)
        {
            if (this.tvOperate.Nodes.Count != 0)
            {
                if (this.tvOperate.SelectedNode == null)
                {
                    CMSTMsgBox.MsgBox.ShowDialog("请选择菜单!!!");
                    return;
                }
                this.btnSaveOperate.Enabled = true;
                tempMenuID = Convert.ToInt32(this.tvOperate.SelectedNode.Tag);     
                this.txtMenu.Text = tempMenuID.ToString();          
            }
        }

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tempNode != null)
            {
                tempNode.BackColor = SystemColors.Window;//上次选择的节点恢复到默认背景色
            }
            e.Node.BackColor = SystemColors.MenuHighlight;//当前选择的节点激活背景色
            tempNode = e.Node;//更新当前节点
        }
    }

}
