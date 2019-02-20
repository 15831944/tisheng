using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSTMsgBox
{
    public partial class MsgBox : Form
    {      
        static private MsgBox newMsgBox =new MsgBox();      
        static private Icon frmIcon;
        static private DialogResult MYReturnButton ;
        public enum MyButtons
        {
            OK,
            OKCancel,
            RetryCancel,
            YesNo,
            YesNoCancel,
            AbortRetryIgnore
        }
        public enum MyIcons
        {
            Information,
            Error,
            Exclamation,
            Asterisk,
            Shield,         
            Question,                 
            Warning
        }
        public MsgBox()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
            base.StartPosition = FormStartPosition.CenterParent;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Message">提示信息</param>
        /// <returns></returns>
        static public DialogResult ShowDialog(string Message)
        {
            CreateMsgBox("");
            newMsgBox.Width = 200;
            newMsgBox.Height = 170;         
            ShowMessage(Message);
            newMsgBox.frmMessage.Top = 40;
            newMsgBox.frmMessage.Height =40;
            newMsgBox.frmpBox.Visible = false;
            ShowMsgBoxIcon(false);              
            ShowOKButton((newMsgBox.Width - newMsgBox.btnOK.Width) / 2, newMsgBox.Height - newMsgBox.btnOK.Height - 50);           
            newMsgBox.ShowDialog();
            return MYReturnButton;
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="Message">提示信息</param>
        /// <param name="Title">标题</param>
        /// <returns></returns>
        static public DialogResult ShowDialog(string Message,string Title)
        {
            CreateMsgBox(Title);
            newMsgBox.Width = 200;
            newMsgBox.Height = 170;          
            ShowMessage(Message);
            newMsgBox.frmMessage.Top = 25;
            newMsgBox.frmMessage.Height = 55;
            newMsgBox.frmpBox.Visible = false;
            ShowMsgBoxIcon(false);
            ShowOKButton((newMsgBox.Width - newMsgBox.btnOK.Width) / 2, newMsgBox.Height - newMsgBox.btnOK.Height - 50);            
            newMsgBox.ShowDialog();
            return MYReturnButton;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Message">提示信息</param>
        /// <param name="Title">标题</param>
        /// <param name="MsgBoxIcon">窗体系统图标</param>
        /// <returns></returns>
        static public DialogResult ShowDialog(string Message, string Title,bool MsgBoxIcon)
        {
            CreateMsgBox(Title);
            newMsgBox.Width = 200;
            newMsgBox.Height = 170;
            newMsgBox.frmMessage.Height = 40;
            newMsgBox.frmpBox.Visible = true;
            ShowPictureBox(MyIcons.Information);
            ShowMessage(Message);
            ShowMsgBoxIcon(MsgBoxIcon);
            ShowOKButton((newMsgBox.Width - newMsgBox.btnOK.Width) / 2, newMsgBox.Height - newMsgBox.btnOK.Height - 50);
            newMsgBox.ShowDialog();
            return MYReturnButton;
        }
        /// <summary>
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="Message">提示信息</param>
        /// <param name="Title">标题</param>
        /// <param name="frmButton">按钮类型</param>
        /// <returns></returns>
        static public DialogResult ShowDialog(string Message, string Title, MyButtons frmButton)
        {
            CreateMsgBox(Title);
            newMsgBox.Width = 250;
            newMsgBox.Height = 170;
            newMsgBox.frmMessage.Height = 40;
            newMsgBox.frmpBox.Visible = true;
            ButtonStatements(frmButton);
            ShowPictureBox(MyIcons.Information);
            ShowMessage(Message);
            ShowMsgBoxIcon(false);
            newMsgBox.ShowDialog();
            return MYReturnButton;
        }
        /// <summary>
        ///       
        /// </summary>
        /// <param name="Message">提示信息</param>
        /// <param name="Title">标题</param>
        /// <param name="frmButton">按钮类型</param>
        /// <param name="MsgBoxIcon">窗体系统图标</param>
        /// <returns></returns>
        static public DialogResult ShowDialog(string Message, string Title, MyButtons frmButton, bool MsgBoxIcon)
        {
            CreateMsgBox(Title);
            newMsgBox.Width = 250;
            newMsgBox.Height = 170;
            newMsgBox.frmMessage.Height = 40;
            newMsgBox.frmpBox.Visible = true;
            ButtonStatements(frmButton);
            ShowPictureBox(MyIcons.Information);
            ShowMessage(Message);
            ShowMsgBoxIcon(MsgBoxIcon);
            newMsgBox.ShowDialog();
            return MYReturnButton;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Message">提示信息</param>
        /// <param name="Title">标题</param>
        /// <param name="frmButton">按钮类型</param>
        /// <param name="frmIcons">消息图标类型</param>
        /// <returns></returns>
        static public DialogResult ShowDialog(string Message, string Title, MyButtons frmButton,MyIcons frmIcons)
        {
            CreateMsgBox(Title);
            newMsgBox.Width = 250;
            newMsgBox.Height = 170;
            newMsgBox.frmMessage.Height = 40;
            newMsgBox.frmpBox.Visible = true;
            ButtonStatements(frmButton);
            ShowPictureBox(frmIcons);
            ShowMessage(Message);
            ShowMsgBoxIcon(false);
            newMsgBox.ShowDialog();
            return MYReturnButton;
        }
        /// <summary>
        /// 
        ///     
        /// </summary>
        /// <param name="Message">提示信息</param>
        /// <param name="Title">标题</param>
        /// <param name="frmButton">按钮类型</param>
        /// <param name="frmIcons">消息图标类型</param>
        /// <param name="MsgBoxIcon">窗体系统图标</param>
        /// <returns></returns>
        static public DialogResult ShowDialog(string Message, string Title, MyButtons frmButton, MyIcons frmIcons, bool MsgBoxIcon)
        {
            CreateMsgBox(Title);
            newMsgBox.Width = 250;
            newMsgBox.Height = 170;
            newMsgBox.frmMessage.Height = 40;
            newMsgBox.frmpBox.Visible = true;
            ButtonStatements(frmButton);
            ShowPictureBox(frmIcons);
            ShowMessage(Message);
            ShowMsgBoxIcon(MsgBoxIcon);
            newMsgBox.ShowDialog();
            return MYReturnButton;
        }
        static private void CreateMsgBox(string title)
        {
           // newMsgBox = new MsgBox();
            newMsgBox.Text = title;
            newMsgBox.btnOK.Visible = false;
            newMsgBox.btnCancel.Visible = false;
            newMsgBox.btnYES.Visible = false;
            newMsgBox.btnNO.Visible = false;
            newMsgBox.btnRetry.Visible = false;
            newMsgBox.btnAbort.Visible = false;
            newMsgBox.btnIgnore.Visible = false;
            MYReturnButton = DialogResult.Ignore;

        }
        static private void ShowMsgBoxIcon(bool msgBoxIcon)
        {
            newMsgBox.ShowIcon = false;
            if (msgBoxIcon==true)
            {
                newMsgBox.ShowIcon = true;
            }
            
        }
        static private void ShowPictureBox(MyIcons mIcons)
        {
            if (mIcons==MyIcons.Information)
            {
                frmIcon = SystemIcons.Information;               
            }
            if (mIcons==MyIcons.Question)
            {
                frmIcon = SystemIcons.Question;
            }
            if (mIcons==MyIcons.Warning)
            {
                frmIcon = SystemIcons.Warning;
            }
            if (mIcons==MyIcons.Error)
            {
                frmIcon = SystemIcons.Error;
            }
            if (mIcons==MyIcons.Exclamation)
            {
                frmIcon = SystemIcons.Exclamation;
            }
            if (mIcons==MyIcons.Asterisk)
            {
                frmIcon = SystemIcons.Asterisk;
            }
            if (mIcons==MyIcons.Shield)
            {
                frmIcon = SystemIcons.Shield;
            }                    
            Image pimage = new Bitmap(frmIcon.ToBitmap());
            newMsgBox.frmpBox.Image = pimage;
            newMsgBox.frmpBox.Left= (newMsgBox.Width - newMsgBox.frmpBox.Width) / 2;
            newMsgBox.frmpBox.Top=  15 ;
        }
        static private void ShowMessage(string frmMessage)
        {
            newMsgBox.frmMessage.Text = frmMessage;
            newMsgBox.frmMessage.Left= (newMsgBox.Width - newMsgBox.frmMessage.Width) / 2;
            newMsgBox.frmMessage.Top = 55;

        }
        static private void ButtonStatements(MyButtons mButtons)
        {
            if (mButtons==MyButtons.OKCancel)
            {            
                ShowOKButton((newMsgBox.Width - newMsgBox.btnOK.Width*2)/3, newMsgBox.Height - newMsgBox.btnOK.Height - 50);
                ShowCancelButton((newMsgBox.Width - newMsgBox.btnCancel.Width*2)/3*2+ newMsgBox.btnCancel.Width, newMsgBox.Height - newMsgBox.btnCancel.Height - 50);
            }
            if (mButtons==MyButtons.OK)
            {
                newMsgBox.Width = 200;
                newMsgBox.Height = 170;
                ShowOKButton((newMsgBox.Width - newMsgBox.btnOK.Width) / 2, newMsgBox.Height - newMsgBox.btnOK.Height - 50);
            }
            if (mButtons==MyButtons.YesNo)
            {
                ShowYesButton((newMsgBox.Width - newMsgBox.btnYES.Width * 2) / 3, newMsgBox.Height - newMsgBox.btnYES.Height - 50);
                ShowNoButton((newMsgBox.Width - newMsgBox.btnNO.Width * 2) / 3 * 2 + newMsgBox.btnNO.Width-10, newMsgBox.Height - newMsgBox.btnNO.Height - 50);
            }
            if (mButtons==MyButtons.RetryCancel)
            {
                ShowRetryButton((newMsgBox.Width - newMsgBox.btnRetry.Width * 2) / 3, newMsgBox.Height - newMsgBox.btnRetry.Height - 50);
                ShowCancelButton((newMsgBox.Width - newMsgBox.btnCancel.Width * 2) / 3 * 2 + newMsgBox.btnCancel.Width, newMsgBox.Height - newMsgBox.btnCancel.Height - 50);
            }
            if (mButtons==MyButtons.YesNoCancel)
            {
                newMsgBox.Width = 310;
                newMsgBox.Height = 170;
                ShowYesButton((newMsgBox.Width - newMsgBox.btnYES.Width * 3) / 4, newMsgBox.Height - newMsgBox.btnYES.Height - 50);
                ShowNoButton((newMsgBox.Width - newMsgBox.btnNO.Width * 3) / 4 * 2 + newMsgBox.btnNO.Width , newMsgBox.Height - newMsgBox.btnNO.Height - 50);
                ShowCancelButton((newMsgBox.Width - newMsgBox.btnCancel.Width * 3) / 4 * 3 + newMsgBox.btnCancel.Width*2, newMsgBox.Height - newMsgBox.btnCancel.Height - 50);
            }
            if (mButtons==MyButtons.AbortRetryIgnore)
            {
                newMsgBox.Width = 310;
                newMsgBox.Height = 170;
                ShowAbortButton((newMsgBox.Width - newMsgBox.btnAbort.Width * 3) / 4, newMsgBox.Height - newMsgBox.btnAbort.Height - 50);
                ShowRetryButton((newMsgBox.Width - newMsgBox.btnRetry.Width * 3) / 4 * 2 + newMsgBox.btnRetry.Width, newMsgBox.Height - newMsgBox.btnRetry.Height - 50);
                ShowIgnoreButton((newMsgBox.Width - newMsgBox.btnIgnore.Width * 3) / 4 * 3 + newMsgBox.btnIgnore.Width * 2, newMsgBox.Height - newMsgBox.btnIgnore.Height - 50);
            }
        }
        static private void ShowOKButton(int x,int y)
        {         
            newMsgBox.btnOK.Visible = true;
            newMsgBox.btnOK.Left = x;
            newMsgBox.btnOK.Top = y;
        }
       static private void ShowCancelButton(int x,int y)
        {
            newMsgBox.btnCancel.Visible = true;
            newMsgBox.btnCancel.Left = x;
            newMsgBox.btnCancel.Top = y;
        }
        static private void ShowYesButton(int x, int y)
        {
            newMsgBox.btnYES.Visible = true;
            newMsgBox.btnYES.Left = x;
            newMsgBox.btnYES.Top = y;
        }
        static private void ShowNoButton(int x, int y)
        {
            newMsgBox.btnNO.Visible = true;
            newMsgBox.btnNO.Left = x;
            newMsgBox.btnNO.Top = y;
        }
        static private void ShowRetryButton(int x, int y)
        {
            newMsgBox.btnRetry.Visible = true;
            newMsgBox.btnRetry.Left = x;
            newMsgBox.btnRetry.Top = y;
        }
        static private void ShowAbortButton(int x, int y)
        {
            newMsgBox.btnAbort.Visible = true;
            newMsgBox.btnAbort.Left = x;
            newMsgBox.btnAbort.Top = y;
        }
        static private void ShowIgnoreButton(int x, int y)
        {
            newMsgBox.btnIgnore.Visible = true;
            newMsgBox.btnIgnore.Left = x;
            newMsgBox.btnIgnore.Top = y;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            MYReturnButton = DialogResult.OK;
            newMsgBox.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MYReturnButton = DialogResult.Cancel;
            newMsgBox.Close();
        }

        private void btnYES_Click(object sender, EventArgs e)
        {
            MYReturnButton = DialogResult.Yes;
            newMsgBox.Close();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            MYReturnButton = DialogResult.No;
            newMsgBox.Close();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            MYReturnButton = DialogResult.Retry;
            newMsgBox.Close();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            MYReturnButton = DialogResult.Abort;
            newMsgBox.Close();
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            MYReturnButton = DialogResult.Ignore;
            newMsgBox.Close();
        }

        private void MsgBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            newMsgBox.Close();
        }
    }
}
