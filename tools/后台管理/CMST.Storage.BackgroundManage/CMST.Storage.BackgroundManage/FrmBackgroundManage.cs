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
    public partial class FrmBackgroundManage : Form
    {
        public FrmBackgroundManage()
        {
            InitializeComponent();  
        }
        public Button BtnDatabase
        {
            get { return this._btnDatabase; }
        }
        public Button BtnOrganization
        {
            get { return this._btnOrganization; }
        }
        public Button BtnAuthority
        {
            get { return this._btnAuthority; }
        }
        public Button BtnBaseMessage
        {
            get { return this._btnBaseMessage; }
        }

    }
}
