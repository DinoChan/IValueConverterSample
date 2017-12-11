using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace IValueConverterSample
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
    }

    public class TestModel
    {
        public bool TrueValue => true;

        public bool FalseValue => false;

        public double DoubleValue => 2000.12;

        public DateTime Date => DateTime.Now;

        public ClickMode ClickModeValue => ClickMode.Release;

        public IEnumerable<ClickMode> ClickModes => new List<ClickMode> { ClickMode.Hover, ClickMode.Press, ClickMode.Release };
      
    }

    public class MyContentControl : ContentControl
    {
        /// <summary>
        /// 获取或设置Amount的值
        /// </summary>  
        public decimal Amount
        {
            get { return (decimal)GetValue(AmountProperty); }
            set { SetValue(AmountProperty, value); }
        }

        /// <summary>
        /// 标识 Amount 依赖属性。
        /// </summary>
        public static readonly DependencyProperty AmountProperty =
            DependencyProperty.Register("Amount", typeof(decimal), typeof(MyContentControl), new PropertyMetadata(default(decimal), OnAmountChanged));

        private static void OnAmountChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MyContentControl target = obj as MyContentControl;
            decimal oldValue = (decimal)args.OldValue;
            decimal newValue = (decimal)args.NewValue;
            if (oldValue != newValue)
                target.OnAmountChanged(oldValue, newValue);
        }

        protected virtual void OnAmountChanged(decimal oldValue, decimal newValue)
        {
            Content = "Amount is " + newValue;
        }



    }
}