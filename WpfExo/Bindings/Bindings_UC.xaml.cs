using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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

namespace WpfExo.Bindings
{
    /// <summary>
    /// Logique d'interaction pour Bindings_UC.xaml
    /// </summary>
    public partial class Bindings_UC : UserControl
    {
        


        //<!--MaxHeight="{Binding RowDefinitions[0].ActualHeight, RelativeSource={RelativeSource AncestorType=Grid}}"--!>

        public Bindings_UC()
        {
            InitializeComponent();
            DataContext = new Bindings_VM();
        }
    }
}
