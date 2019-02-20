using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMST.Storage.Client.Proxy
{
    public class FileLog
    {
        /// <summary>
        /// 输出日志信息到本地日志文件Debug中
        /// </summary>
        /// <param name="operatorDT">当前操作时间</param>
        /// <param name="operators">当前操作人</param>
        /// <param name="describe">操作描述</param>
        /// <param name="state">操作状态</param>
        /// <param name="info">返回信息</param>
        /// <returns></returns>
        public static void FileLogToLocal(DateTime operatorDT, string operators, string describe, string state, string info)
        {
            string password = "0000";
            //string debugPath = System.Windows.Forms.Application.StartupPath;//获取debug文件路径
            string UserPath= System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);//获取当前系统登录用户目录
            string LogPath = Path.Combine(UserPath, "CmstStorageLog");//在当前系统登录用户目录下创建CmstStorageLog文件夹
            string YearString = DateTime.Now.Year.ToString();//获取当前年份
            string YearPath = Path.Combine(LogPath, YearString+"年");
            string MonthString = DateTime.Now.Month.ToString("00");//获取当前月份
            string MonthPath = Path.Combine(YearPath, MonthString+"月");
            Directory.CreateDirectory(MonthPath);
            File.SetAttributes(MonthPath, FileAttributes.Hidden | FileAttributes.System);//设置Log文件夹隐藏,并设置为系统文件

            string nowString = DateTime.Today.ToString("yyyy年MM月dd日");
            string logName = nowString + ".txt";
            string txtLogPath = Path.Combine(MonthPath, logName);//按当天日期新建TXT文件,保存加密前日志文件
            string datName = nowString + ".dat";
            string datLogPath = Path.Combine(MonthPath, datName);//按当天日期新建DAT文件，保存加密后日志文件
            if (File.Exists(datLogPath))
            {
                File.SetAttributes(datLogPath, FileAttributes.Normal);//取消文件的特殊属性，进行文件读写
                DESFileClass.DecryptFile(datLogPath, txtLogPath, password);//日志文件解密                
            }
            using (StreamWriter sw = new StreamWriter(txtLogPath, true, Encoding.Default))
            {
                string str = "**********************************************************************\r\n"
                    + "操作时间：\r\n" + "\t" + operatorDT.ToString() + "\r\n"
                    + "操作人:\r\n" + " \t" + operators + "\r\n"
                    + "操作描述:\r\n" + "\t" + describe + "\r\n"
                    + "操作状态:\r\n" + "\t" + state + "\r\n"
                    + "返回信息:\r\n" + "\t" + info + "\r\n"
                    + "**********************************************************************\r\n" + "\r\n";
                sw.Write(str);
            }


            DESFileClass.EncryptFile(txtLogPath, datLogPath, password);
            File.SetAttributes(datLogPath, FileAttributes.Hidden | FileAttributes.System | FileAttributes.ReadOnly);//设置日志文件为系统文件，并隐藏，只读
            File.Delete(txtLogPath);
        }
    }
}
