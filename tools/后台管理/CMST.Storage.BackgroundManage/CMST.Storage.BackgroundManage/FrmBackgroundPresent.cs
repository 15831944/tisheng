using CMST.Storage.BackgroundManage.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMST.Storage.BackgroundManage
{
    public class FrmBackgroundPresent
    {
        public FrmBackgroundManage View { get; set; }
        public FrmBackgroundPresent(FrmBackgroundManage view)
        {
            this.View = view;
            this.View.BtnDatabase.Click += new EventHandler(BtnDatabaseClick);
            this.View.BtnOrganization.Click += new EventHandler(BtnOrganizationClick);
            this.View.BtnAuthority.Click += new EventHandler(BtnAuthorityClick);
            this.View.BtnBaseMessage.Click += new EventHandler(BtnBaseMessageClick);
        }
        public void BtnDatabaseClick(object sender,EventArgs e)
        {
            FrmDatabase fdb = new FrmDatabase()
            {
                StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            };
            fdb.Show();
        }
        public void BtnOrganizationClick(object sender, EventArgs e)
        {
            FrmOrganizationManage fom = new FrmOrganizationManage();
            fom.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            fom.Show();
        }
        public void BtnAuthorityClick(object sender,EventArgs e)
        {
            FrmAuthorityManage frm = new FrmAuthorityManage();
            frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            frm.Show();
        }
        public void BtnBaseMessageClick(object sender, EventArgs e)
        {
            FrmBaseMessagePresenter form = new FrmBaseMessagePresenter(new FrmBaseMessageManage());
            form.View.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            form.View.Show();
        }
    }
}
