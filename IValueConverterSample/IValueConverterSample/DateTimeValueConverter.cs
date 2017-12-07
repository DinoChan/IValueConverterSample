using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using System.Globalization;

namespace IValueConverterSample
{
    public class DateTimeValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var dateTime = DateTime.Parse(parameter.ToString());

            var culture = new CultureInfo(language);
            return dateTime.ToString(culture.DateTimeFormat);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

}
