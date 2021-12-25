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
using Bike_store.ViewsModels;

namespace Bike_store
{
    /// <summary>
    /// Interaction logic for ReservationCreator.xaml
    /// </summary>
    public partial class ReservationCreator : Window
    {
        public ReservationCreator()
        {
            InitializeComponent();
            DataContext = new ReservationCreatorViewModel();
        }
    }
}
