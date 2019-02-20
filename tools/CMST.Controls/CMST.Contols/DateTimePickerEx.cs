using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMST.Controls
{
    public partial class DateTimePickerEx : UserControl ,IModify
    {
        public DateTimePickerEx()
        {
            InitializeComponent();
            this.dateTimePicker1.ValueChanged += (m, n) => {
                DateTime dt1;
                DateTime dt2;
                dt1 = new DateTime(this.Value.Year, this.Value.Month, this.Value.Day, this.Value.Hour, this.Value.Minute, this.Value.Second);

                dt2 = new DateTime(this._oldValue.Year, this._oldValue.Month, this._oldValue.Day, this._oldValue.Hour, this._oldValue.Minute, this._oldValue.Second);
                if (dt1 != dt2)
                {
                    isModified = true;
                }
                else
                {
                    isModified = false;
                }
            };

            this.monthCalendar1.LostFocus += new EventHandler((o, e )=> {

                this.HideCal();
            });
           
        }

        public void LostEvent(object o,EventArgs e)
        {
            this.HideCal();
        }

        private bool _isShow = false;

        private bool isModified;
        public bool IsModified
        {
            get { return this.isModified; }
        }

        private DateTime _oldValue;

        public DateTime Value
        {
            get { return this.dateTimePicker1.Value; }
            set { this.dateTimePicker1.Value = value; }
        }
        public string CustomFormat {
            get { return this.dateTimePicker1.CustomFormat; }
            set { this.dateTimePicker1.CustomFormat = value; }
        }
        public DateTimePickerFormat Format {
            get { return this.dateTimePicker1.Format; }
            set { this.dateTimePicker1.Format = value; }
        }
        public DateTimePicker DateTimePicker {
            get { return this.dateTimePicker1; }
            set { this.dateTimePicker1 = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_isShow)
                ShowCal();
            else
                HideCal();

        }

        private void ShowCal()
        {
            this.Height = 220;
            _isShow = true;
            this.monthCalendar1.Parent = FindRoot(this);
            this.monthCalendar1.BringToFront();
            Point p = (LocationOnClient(this));
            AddAllChildHide(this.monthCalendar1.Parent);
            p.Y += 27;
            p.X += 0;
            this.monthCalendar1.Location = p;

        }

        private Control FindRoot(Control c)
        {
            if(c.Parent == null)
            {
                return c;
            }
            else
            {
                return FindRoot(c.Parent);
            }
        }

        private void AddAllChildHide(Control c)
        {
            if (c == this)
            {
                return;
            }
            else
            {
                c.Click -= LostEvent;
                c.Click += LostEvent;
            }
            if (c.Controls != null && c.Controls.Count > 0)
            {
                foreach (Control cd in c.Controls)
                {
                    AddAllChildHide(cd);
                }
            }
            
        }
      
        /*
        private void AddParentHide(Control c)
        {
            if (c.Parent != null)
            {
                c.Parent.Click -= LostEvent;
                c.Parent.Click += LostEvent;
                AddParentHide(c.Parent);
            }
        }*/

       

        private Point LocationOnClient(Control c)
        {
            Point retval = new Point(0, 0);
            for (; c.Parent != null; c = c.Parent)
            {
                retval.Offset(c.Location);
            }
            return retval;
        }

        private void HideCal()
        {
            this.monthCalendar1.Parent = this;
            this.Height = 25;
            _isShow = false;
            this.monthCalendar1.Parent = this;
        }

        
        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            this.HideCal();
            this.dateTimePicker1.Value = this.monthCalendar1.SelectionStart;
        }

        public void Reset()
        {
            isModified = false;
            this._oldValue = this.dateTimePicker1.Value; 
        }

        private void DateTimePickerEx_Leave(object sender, EventArgs e)
        {
           // this.HideCal();
        }

        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            this.HideCal();
        }

        private void DateTimePickerEx_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        

        protected override void OnLostFocus(EventArgs e)
        {
          
           
            this.HideCal();
            base.OnLostFocus(e);
        }
    }
}
