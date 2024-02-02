using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfExo.Exercices
{
    /// <summary>
    /// Logique d'interaction pour Exo6_UC.xaml
    /// </summary>
    public partial class Exo6_UC : UserControl
    {
        public Exo6_UC()
        {
            InitializeComponent();
            StackPanel sp1 = new StackPanel();
            sp1.HorizontalAlignment = HorizontalAlignment.Center;
            sp1.VerticalAlignment = VerticalAlignment.Center;
            Label lbl = new Label();
            lbl.Content = "Hello";
            lbl.HorizontalAlignment = HorizontalAlignment.Center;
            Button btn1 = new Button();
            btn1.HorizontalAlignment = HorizontalAlignment.Center;
            btn1.Content = "...";
            btn1.Width = 100;
            btn1.Height = 50;
            btn1.Click += Btn1_Click;
            this.Content = sp1;
            sp1.Children.Add(lbl);
            sp1.Children.Add(btn1);
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("World");
        }
    }
}
