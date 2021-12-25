using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_store.ViewsModels
{
    class ManageStoresViewModel
    {
        //All the stores
        public ObservableCollection<Store> P_StoresList { get; set; }

        //All the buttons
        public RelayCommand P_SaveStore { get; set; }
        public RelayCommand P_DeleteStore { get; set; }
        public RelayCommand P_EditStore { get; set; }

        //Input text
        public string P_StoreStreetText { get; set; }
        public string P_StoreCityText { get; set; }
        public int P_StoreCapacityNumber { get; set; }

        //Selected Store input field
        public Store P_SelectedStore { get; set; }

        //Initializes all content on the window
        private void Init()
        {
            P_SaveStore = new RelayCommand(Save);
            P_DeleteStore = new RelayCommand(Delete);
            P_EditStore = new RelayCommand(Edit);
        }

        public ManageStoresViewModel()
        {
            Init();
        }

        //Create a store with the input field data
        private void Save(object sender)
        {
            Store store = new Store
            {
                P_StreetName = P_StoreStreetText,
                P_City = P_StoreCityText,
                P_MaxCapacity = P_StoreCapacityNumber
            };

            P_StoresList.Add(store);
        }

        //Delete an excisting selected store from the Listbox
        private void Delete(object sender)
        {
            if (P_SelectedStore != null)
            {
                P_StoresList.Remove(P_SelectedStore);
            }
        }

        //Edit an excisting selected store from the Listbox
        private void Edit(object sender)
        {
            if (P_SelectedStore != null)
            {
                P_SelectedStore.P_StreetName = P_StoreStreetText;
                P_SelectedStore.P_City = P_StoreCityText;
                P_SelectedStore.P_MaxCapacity = P_StoreCapacityNumber;
            }
        }
    }
}
