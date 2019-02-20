using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;


namespace CMST.Storage.Client.Proxy
{
    public class MachineCode
    {
        public static MachineCode machineCode;
        //获取机器名
        public string GetHostName()
        {
            return System.Net.Dns.GetHostName();
        }
        //获取CPU序列号
        public string GetCpuID()
        {
            string strCpuID = "";
            try
            {
                ManagementClass mc = new ManagementClass("win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    strCpuID = mo.Properties["ProcessorId"].Value.ToString();
                    break;
                }
                return strCpuID;
            }
            catch
            {
                return strCpuID;
            }
        }

        //获取硬盘编号

        public string GetHardDiskID()
        {
            string strHardDiskID = "";
            try
            {
                ManagementClass mc = new ManagementClass("Win32_DiskDrive");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    strHardDiskID = mo.Properties["Model"].Value.ToString();
                    break;
                }
                return strHardDiskID;
            }
            catch
            {
                return strHardDiskID;
            }
        }

        //获取网卡硬件地址
        public string GetMoAddress()
        {
            string MoAddress = "";
            try
            {
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        MoAddress = mo["MacAddress"].ToString();
                    }
                }
                return MoAddress;
            }
            catch
            {
                return MoAddress;
            }
        }

        public static string GetMachineCodeString()
        {
            string machineCodeString = string.Empty;
            if (machineCode == null)
            {
                machineCode = new MachineCode();
            }
            //machineCodeString = "PC." + machineCode.GetHostName() + "."
            //    + machineCode.GetCpuID() + "."
            //    + machineCode.GetHardDiskID() + "."
            //    + machineCode.GetMoAddress();
            machineCodeString = "PC." + machineCode.GetMoAddress();
            return machineCodeString;
        }
    }
}
