using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace CMST.Storage.Client.UIMatch
{
    public static class SetDataView
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtSource"></param>
        /// <param name="dtCol"></param>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public static void SetColMartchName(DataSet dsCol, DataGridView dgv)
        {
            int i = 0;
            if (dsCol != null)
            {
                if (dsCol.Tables.Count > 0)
                {
                    if (dsCol.Tables[0].Rows.Count > 0)
                    {

                        foreach (DataRow dr in dsCol.Tables[0].Rows)
                        {
                            bool isvisible = Convert.ToBoolean(dr["IsVisible"]);
                            if (isvisible)
                            {
                                dgv.Columns[dr["DisplayField"].ToString()].HeaderText = dr["Name"].ToString();
                                dgv.Columns[dr["DisplayField"].ToString()].DisplayIndex = i++;
                            }
                        }
                    }
                }
            }
        }

        public static string GetFieldStr(DataSet dsCol)
        {
            StringBuilder strFileds = new StringBuilder();
            foreach (DataRow dr in dsCol.Tables[0].Rows)
            {
                bool hasCol = Convert.ToBoolean(dr["IsVisible"]);
                //   if (hasCol && dr["DisplayField"].ToString() != "DefaultID")
                if (hasCol &&!dr["DisplayField"].ToString().Contains("DefaultID"))
                {
                    strFileds.Append(" [");
                    strFileds.Append(dr["QueryField"].ToString());
                    strFileds.Append("] as [");
                    strFileds.Append(dr["DisplayField"].ToString());
                    strFileds.Append("], ");
                }
                else if (dr["DisplayField"].ToString().Contains("DefaultID"))
                {
                    strFileds.Append(" [");
                    strFileds.Append(dr["QueryField"].ToString());
                    strFileds.Append("] as [");
                    strFileds.Append(dr["DisplayField"].ToString());
                    strFileds.Append("], ");
                }
            }
            return strFileds.ToString().TrimEnd(' ').TrimEnd(',');
        }

        public static void SaveConfigDataSet(DataSet ds, string directory, string filename)
        {
            string strdir = System.Windows.Forms.Application.StartupPath + "/" + directory;
            string strfile = strdir + "/" + filename;
            if (!Directory.Exists(strdir))
            {
                Directory.CreateDirectory(strdir);
            }
            if (!File.Exists(strfile))
            {
                FileStream fs = File.Create(strfile);
                fs.Close();
            }
            ds.WriteXml(strfile);
        }

        public static DataSet ConvertXMLFileToDataSet(string xmlFile)
        {
            StringReader stream = null;
            XmlTextReader reader = null;
            try
            {
                XmlDocument xmld = new XmlDocument();
                xmld.Load(xmlFile);
                DataSet xmlDS = new DataSet();
                stream = new StringReader(xmld.InnerXml);
                //从stream装载到XmlTextReader  
                reader = new XmlTextReader(stream);
                xmlDS.ReadXml(reader);
                //xmlDS.ReadXml(xmlFile);  
                return xmlDS;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public static DataSet LoadConfigDataSet(string directory, string filename)
        {
            try
            {
                string str = System.Windows.Forms.Application.StartupPath + "/" + directory + "/" + filename;

                DataSet ds = new DataSet();
                ds.ReadXml(str);
                return ds;

            }
            catch
            {
                return null;
            }
        }
    }
}
