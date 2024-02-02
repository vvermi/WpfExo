//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;

//namespace WpfExo.Bindings
//{
//    internal class DoubleToHeightConverter : IValueConverter
//    {
//        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
//        {
//            var test = new System.Windows.GridLengthConverter();
//            var testOut = test.ConvertFrom(value);
//            //MessageBox.Show("Convert: " + value.GetType().ToString() + " to " + testOut.GetType().ToString());
//            return testOut;
//        }

//        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
//        {

//            MessageBox.Show(value.GetType().ToString());

//            if (((GridLength)value).IsStar ) return 50; 


//            var test = new System.Windows.GridLengthConverter();
//            double _d = 0;
            
//            var testOut = (double)test.ConvertTo(value, _d.GetType());
            
//            //MessageBox.Show("ConvertBack :" + value.GetType().ToString() + " to " + testOut.GetType().ToString());
//            return testOut;
//        }
//    }
//}
