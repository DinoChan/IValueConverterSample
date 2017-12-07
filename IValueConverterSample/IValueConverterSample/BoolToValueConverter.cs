using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace IValueConverterSample
{
    public class BoolToValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            
            if (value == null || (bool) value == false)

                return DependencyProperty.UnsetValue;
            return parameter;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return Equals(value, parameter);
        }
    }
}