using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bike_store.ViewsModels
{
    class MainWindowViewModel
    {
        public ObservableCollection<Store> P_StoreList { get; set; }
        public Store P_SelectedStore { get; set; }
        public RelayCommand P_CreateNewBike { get; set; }
        public RelayCommand P_CreateReservation { get; set; }
        public RelayCommand P_ExitApplication { get; set; }
        public RelayCommand P_CreateCustomer { get; set; }
        public RelayCommand P_CreateNewStoreClick { get; set; }

        public MainWindowViewModel()
        {
            P_CreateNewBike = new RelayCommand(CreateNewbike);
            P_CreateReservation = new RelayCommand(CreateRes);
            P_CreateNewStoreClick = new RelayCommand(CreateNewStore);
            P_ExitApplication = new RelayCommand(ExitApp);
            P_CreateCustomer = new RelayCommand(CreateCus);
            P_StoreList = new ObservableCollection<Store>();
        }

        //Opens the bike window
        public void CreateNewbike(object sender)
        {
            // Check if a store is selected
            if (P_SelectedStore == null)
            {
                NoStoreError();
                return;
            }

            BikeCreator _bikewindow = new BikeCreator();
            BikeCreatorViewModel temp = new BikeCreatorViewModel();

            temp.P_Store = P_SelectedStore;
            temp.P_StoreList = P_StoreList;

            _bikewindow.DataContext = temp;
            _bikewindow.Show();
        }

        //Opens the reservation window
        public void CreateRes(object sender)
        {
            // Check if a store is selected
            if (P_SelectedStore == null)
            {
                NoStoreError();
                return;
            }

            ReservationCreator _window = new ReservationCreator();
            ReservationCreatorViewModel temp = new ReservationCreatorViewModel();

            temp.P_Store = P_SelectedStore;

            _window.DataContext = temp;
            _window.Show();
        }

        //Opens the store creation window
        public void CreateNewStore(object sender)
        {
            ManageStores _storewindow = new ManageStores();
            ManageStoresViewModel temp = new ManageStoresViewModel();

            temp.P_StoresList = P_StoreList;

            _storewindow.DataContext = temp;
            _storewindow.Show();
        }

        //Opens the window for creating customers These are linked to the store
        public void CreateCus(object sender)
        {
            // Check if a store is selected
            if (P_SelectedStore == null)
            {
                NoStoreError();
                return;
            }

            CreateCustomer _window = new CreateCustomer();
            CreateCustomerViewModel temp = new CreateCustomerViewModel();

            temp.P_Store = P_SelectedStore;

            _window.DataContext = temp;
            _window.Show();
        }

        //Closes application 
        public void ExitApp(object sender)
        {
            Environment.Exit(1);
        }

        private void NoStoreError()
        {
            MessageBox.Show("Selecteer een winkel!");
        }
    }
}
