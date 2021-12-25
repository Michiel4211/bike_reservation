using Bike_store.ViewsModels;
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
using System.Windows.Shapes;

namespace Bike_store
{
    /// <summary>
    /// Interaction logic for ManageStores.xaml
    /// </summary>
    public partial class ManageStores : Window
    {
        public ManageStores()
        {
            InitializeComponent();
            DataContext = new ManageStoresViewModel();
        }
    }
}
