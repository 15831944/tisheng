using MD5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMST.Storage.BackgroundManage
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmBackgroundManage view = new FrmBackgroundManage();
            FrmBackgroundPresent fbgp = new FrmBackgroundPresent(view);
            Application.Run(fbgp.View);
        }
    }
}
