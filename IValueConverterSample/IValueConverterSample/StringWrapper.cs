using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IValueConverterSample
{
    public class StringWrapper
    {
        public string this[string key]
        {
            get
            {
                return key;
            }
        }
    }
}
