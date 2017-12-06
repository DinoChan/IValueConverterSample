using System;
using System.Diagnostics.CodeAnalysis;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace IValueConverterSample
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public bool InvertBoolean { get; set; } = false;


        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var result = Visibility.Collapsed;

            if ((value as bool? ^ InvertBoolean) == true)
                result = Visibility.Visible;
            
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            var visibility = (Visibility)value;
            return (visibility == Visibility.Visible) ^ InvertBoolean;
        }
    }
}