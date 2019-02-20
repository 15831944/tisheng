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

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        Person person = new Person();
        public Form3()
        {
            InitializeComponent();
            person.Cds = new List<Child>();
            this.textBox1.DataBindings.Add("Text", person, "Name");
            this.textBox2.DataBindings.Add("Text", person, "Age");
            
            this.dataGridView1.DataSource = new BindingList<Child>(person.Cds);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = "xiemaolin";
            p.Age = 25;

            Child c1 = new Child();
            c1.Name = "xml";
            c1.Height = 1.8M;

            Child c2 = new Child();
            c2.Name = "json";
            c2.Height = 1.8M;
            p.Cds = new List<Child>();
            p.Cds.Add(c1);
            p.Cds.Add(c2);
            person.Cds.Add(c1);
             person.Cds.Add(c2);
//         //    this.dataGridView1.DataSource = new List<Child>();
 //            this.dataGridView1.DataSource = person.Cds;
//                          Person pp = JsonConvert.DeserializeObject<Person>(JsonConvert.SerializeObject(p));
//                        EntityToEntity<Person>(pp, person);

        }

        public static void EntityToEntity<T>(T pTargetObjSrc, T pTargetObjDest)
        {
            try
            {
                foreach (var mItem in typeof(T).GetProperties())
                {
                    Type typeInterface = mItem.PropertyType.GetInterface("IList", true);
                    if(typeInterface != null)
                    {
                        var pch = mItem.GetValue(pTargetObjSrc, new object[] { });
                        var a = pTargetObjDest.GetType();
                        var b = a.GetProperty(mItem.Name);
                        var chs = b.GetValue(pTargetObjDest, new object[] { });
                        chs.GetType().GetMethod("Clear").Invoke(chs, null);
                        chs.GetType().GetMethod("AddRange").Invoke(chs, new object[] { pch });
                    }
                    else
                        mItem.SetValue(pTargetObjDest, mItem.GetValue(pTargetObjSrc, new object[] { }), null);
                }
            }
            catch (NullReferenceException NullEx)
            {
                throw NullEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
