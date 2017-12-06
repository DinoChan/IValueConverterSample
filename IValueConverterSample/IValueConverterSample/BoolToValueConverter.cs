using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace IValueConverterSample
{
    public class BoolToValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null || (bool)value == false)
                return DependencyProperty.UnsetValue;
            else
                return parameter;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return object.Equals(value, parameter);
        }
    }
}
