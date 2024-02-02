using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfExo
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Quitter(object sender, RoutedEventArgs e)
        {
            if (((MenuItem)sender).Header.Equals("Quitter"))
                this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            string myClassString = "WpfExo.Exercices." + ((MenuItem)sender).Name + "_UC";
            UserControl userControl = (UserControl)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(myClassString);
            MainControl1.Content = userControl;



            #region avec switch
            //switch (((MenuItem)sender).Name)
            //{
            //    case "Exo1":
            //        MainControl1.Content = new Exercices.Exo1_UC();
            //        break;
            //    case "Exo2":
            //        MainControl1.Content = new Exercices.Exo2_UC();
            //        break;
            //    case "Exo3":
            //        MainControl1.Content = new Exercices.Exo3_UC();
            //        break;
            //    case "Exo4":
            //        MainControl1.Content = new Exercices.Exo4_UC();
            //        break;
            //    case "Exo5":
            //        MainControl1.Content = new Exercices.Exo5_UC();
            //        break;
            //    case "Exo6":
            //        MainControl1.Content = new Exercices.Exo6_UC();
            //        break;
            //    case "Exo7":
            //        MainControl1.Content = new Exercices.Exo7_UC();
            //        break;
            //    case "Exo8":
            //        MainControl1.Content = new Exercices.Exo8_UC();
            //        break;
            //    case "Exo9":
            //        MainControl1.Content = new Exercices.Exo9_UC();
            //        break;
            //    case "Exo10":
            //        MainControl1.Content = new Exercices.Exo10_UC();
            //        break;
            //    default:
            //        break;
            //}
            #endregion
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MainControl1.Content = new Bindings.Bindings_UC();
        }
    }
}
