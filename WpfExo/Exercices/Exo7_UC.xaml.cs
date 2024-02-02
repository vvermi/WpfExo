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
    /// Logique d'interaction pour Exo7_UC.xaml
    /// </summary>
    public partial class Exo7_UC : UserControl
    {
        public Exo7_UC()
        {
            InitializeComponent();
            for (int i = 0; i <10; i++)
            { lstBox.Items.Add(i.ToString()); }
        }
    }
}
