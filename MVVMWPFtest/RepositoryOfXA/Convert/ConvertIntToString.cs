using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfXA.Convert
{
    [System.Windows.Data.ValueConversion(typeof(int), typeof(string))]
    public class ConvertIntToString:System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string sex = "";
            if (int.Parse(value.ToString()) == 0)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            return sex;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
