using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Bike_store.ViewsModels;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Bike_store
{
    /// <summary>
    /// Interaction logic for BikeCreator.xaml
    /// </summary>
    public partial class BikeCreator : Window
    {
        public BikeCreator()
        {
            InitializeComponent();
            DataContext = new BikeCreatorViewModel();
        }
    }
}
