using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace IValueConverterSample
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class WhyUsingIValueConverterPage : Page
    {
        public WhyUsingIValueConverterPage()
        {
            this.InitializeComponent();
            
            var testResult = DataContext as TestResult;
            if (testResult != null)
            {
                if (testResult.Passed)
                    ResultElement.Foreground = new SolidColorBrush(Colors.Green);
                else
                    ResultElement.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
    }

    public class TestResult
    {
        public bool Passed { get; set; }

        public Brush TestResultBrush
        {
            get
            {

                if (Passed)
                    return new SolidColorBrush(Colors.Green);
                else
                    return new SolidColorBrush(Colors.Red);
            }
        }


    }

    
}
