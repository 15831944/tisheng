using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Person : INotifyPropertyChanged
    {
        private int age;
        private string name;
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                if (PropertyChanged != null)//监听属性值是否改变
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Age"));
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                if (PropertyChanged != null)//监听属性值是否改变
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;//在更改属性值时发生

        public List<Child> Cds { get; set; }
    }

    public class Child : INotifyPropertyChanged
    {
        private string name;
        private decimal height;

        public string Name {
            get { return name; }
            set
            {
                name = value;
                if (PropertyChanged != null)//监听属性值是否改变
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
        public decimal Height
        {
            get { return height; }
            set
            {
                height = value;
                if (PropertyChanged != null)//监听属性值是否改变
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Height"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
