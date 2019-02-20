using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMST.Controls
{
    public class CbComBoxEx: ComboBox 
    {

        List<object> ItemSource;
        public CbComBoxEx()
        {

        }

        private bool SetAuto(string str, string input)

        {


             var newList = ItemSource.Where(m => m.GetType().GetProperty(str).GetValue(m).ToString().IndexOf(input, StringComparison.CurrentCultureIgnoreCase) != -1).ToArray();
             if (newList.Count() > 0)
             {
                 this.Items.Clear();
                 this.Items.AddRange(newList.ToArray());
                //var first = newList.Where(m => m.GetType().GetProperty(str).GetValue(m).ToString().Equals(input));
                //if (first.Any()) {
                //    this.SelectedItem = first.First();
                //}

                 //this.DisplayMember = str;
                 return true;
             }
             else
             {
                 this.Items.Clear();
                 this.Items.AddRange(ItemSource.ToArray());
                // this.DisplayMember = strDefault;
                 return false;
             }
     
           /* object[] source = (from m in this.ItemSource
                               where ((m.GetType().GetProperty(str).GetValue(m) != null) && (m.GetType().GetProperty(str).GetValue(m).ToString() != "")) && 
                               (m.GetType().GetProperty(str).GetValue(m).ToString().IndexOf(input, StringComparison.CurrentCultureIgnoreCase) != -1)
                               select m).ToArray<object>();
            if (source.Count<object>() > 0)
            {
                base.Items.Clear();
                base.Items.AddRange(source.ToArray<object>());
                return true;
            }
            base.Items.Clear();
            base.Items.AddRange(this.ItemSource.ToArray());
            return false;*/


        }
        private string strDefault = "";
        private string[] strs;


        public void SetSourceAndAuto(List<object> list, string strDefault, params string[] strs)
        {

            if(list == null)
            {
                throw new NullReferenceException();
            }
            if (Items != null)
                this.Items.Clear();
            if (ItemSource != null)
                this.ItemSource.Clear();           
            this.strDefault = strDefault;
            this.strs = strs;
            this.ItemSource = list;
            this.Items.AddRange(this.ItemSource.ToArray());
            this.DisplayMember = strDefault;

        }

        /*
        protected override void OnTextUpdate(EventArgs e)
         {
            /*var input = this.Text.ToUpper();
            this.Items.Clear();
            int start = this.SelectionStart;
            if (string.IsNullOrWhiteSpace(input))
            {
                this.Items.AddRange(ItemSource.ToArray());
                this.DisplayMember = strDefault;
            }
            else
            {
                foreach (var str in strs)
                {
                    if (SetAuto(str, input))
                    {
                        break;
                    }
                }

                this.DroppedDown = true;
                this.Select(start, this.Text.Length);
                //保持鼠标指针形状  

            }
            Cursor.Current = Cursors.Default;
            base.OnTextUpdate(e);
            
            
         
         }
    */
            /*
        protected override void OnDropDown(EventArgs e)
        {
            
            /*var t = this.SelectedItem;
            int i = this.SelectedIndex;

            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.Items[i] == this.SelectedItem)
                {
                    this.SelectedIndex = i;
                    break;
                }
            }
            base.OnDropDown(e);
            
        }*/


        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (this.Items == null || this.Items.Count == 0)
            {
                return;
            }
           
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(this.Text) || this.ItemSource == null || this.ItemSource.Count == 0 || this.Items == null)
                    return;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                if (!this.DroppedDown)
                {
                    this.DroppedDown = true;
                }
                if (this.SelectedIndex < 0)
                {
                    this.SelectedIndex = 0;
                }
                else
                {
                    this.SelectedIndex--;
                    this.SelectedIndex++;
                }
                return;
            }
            string input = this.Text?.Trim();
            if (input == null)
            {
                return;
            }
          

            
            int start = this.SelectionStart;
            int selection = this.SelectionLength;
            string cstr = selection == 0 ? this.Text : this.Text.Remove(start, selection);

            if (string.IsNullOrWhiteSpace(input))
            {
                this.Items.Clear();
                this.Items.AddRange(ItemSource.ToArray());
                this.DisplayMember = strDefault;
            }
            else
            {
                foreach (var str in strs)
                {
                    if (SetAuto(str, input))
                    {
                        break;
                    }
                }
              
                this.DroppedDown = true;
                this.Text = input;
                this.Select(start, selection);

            }
            Cursor.Current = Cursors.Default;
           

            base.OnKeyUp(e);
        }
        
     
            
        protected override void OnDropDownClosed(EventArgs e)
        {

      
            object ob = null;
            if(this.Items != null)
            {
                if (this.SelectedItem != null)
                {
                    //ob = this.SelectedItem;
                    ob = ItemSource.Find(m => m == this.SelectedItem);
                    this.Items.Clear();

                    if (ItemSource != null)
                        this.Items.AddRange(this.ItemSource.ToArray());
                    this.DisplayMember = strDefault;
                    this.SelectedItem = ob;
                    //if(ob!=null)
                    //this.SelectedItem = ob;
                    // this.DisplayMember = strDefault;
                }
            }
            base.OnDropDownClosed(e);
        }

    
        
        protected override void OnTabIndexChanged(EventArgs e)
        {
            base.OnTabIndexChanged(e);
        }
        
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            if (this.Items.Count == 0)
                return;
            base.OnSelectedIndexChanged(e);
        }

        public void SetDefaultItem(string defaultname, string defaultvalue)
        {
            if (this.ItemSource != null)
                this.SelectedItem = this.ItemSource.Find(m => m.GetType().GetProperty(defaultname).GetValue(m).ToString().Equals(defaultvalue));
        }

        public object GetSelectedItem()
        {
            if (this.SelectedItem != null)
            {
                return SelectedItem.GetType().GetProperty(this.strDefault).GetValue(this.SelectedItem);
            }
            return null;
        }


    }
}
