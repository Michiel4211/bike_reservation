using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bike_store.ViewsModels
{
    class BikeCreatorViewModel
    {
        public Store P_Store { get; set; }
        public ObservableCollection<Store> P_StoreList { get; set; }
        public RelayCommand P_SaveBike { get; set; }
        public RelayCommand P_DeleteBike { get; set; }
        public RelayCommand P_EditBike { get; set; }
        public Bike P_SelectedBike { get; set; }

        //Input text
        public string P_BikeNameText { get; set; }
        public string P_BikeDis { get; set; }
        public double P_HourlyRate { get; set; }
        public double P_DailyRate { get; set; }
        public E_Brand P_BikeBrand { get; set; }
        public E_BikeGender P_BikeGender { get; set; }
        public E_BikeSize P_BikeSize { get; set; }
        public E_BikeType P_BikeType { get; set; }

        public BikeCreatorViewModel()
        {
            Init();
        }

        //Initializes all content on the window
        private void Init()
        {
            P_SaveBike = new RelayCommand(Save);
            P_EditBike = new RelayCommand(Edit);
            P_DeleteBike = new RelayCommand(Delete);
        }

        //Creates bike and adds it to the shop
        private void Save(object sender)
        {
            //Check if the bike inventory is not full
            if (P_Store.P_BikeInventory.Count == P_Store.P_MaxCapacity)
            {
                MessageBox.Show("Helaas, het maximale aantal fietsen is " + P_Store.P_BikeInventory.Count + " en niet " + (P_Store.P_BikeInventory.Count + 1));
                return;
            }

            Bike bike = new Bike();

            bike.P_BikeID = Bike.TotalBikesCreated();
            bike.P_Name = P_BikeNameText;
            bike.P_Discription = P_BikeDis;
            bike.P_BikeBrand = P_BikeBrand;
            bike.P_BikeGender = P_BikeGender;
            bike.P_BikeSize = P_BikeSize;
            bike.P_BikeType = P_BikeType;
            bike.P_HourRate = P_HourlyRate;
            bike.P_DayRate = P_DailyRate;

            P_Store.P_BikeInventory.Add(bike);
        }

        //Delete an excisting selected store from the Listbox
        private void Delete(object sender)
        {
            if (P_SelectedBike != null)
            {
                P_Store.P_BikeInventory.Remove(P_SelectedBike);
            }
        }

        //Edit an excisting selected store from the Listbox
        private void Edit(object sender)
        {
            if (P_SelectedBike != null)
            {
                P_SelectedBike.P_Name = P_BikeNameText;
                P_SelectedBike.P_Discription = P_BikeDis;
                P_SelectedBike.P_BikeBrand = P_BikeBrand;
                P_SelectedBike.P_BikeGender = P_BikeGender;
                P_SelectedBike.P_BikeSize = P_BikeSize;
                P_SelectedBike.P_BikeType = P_BikeType;
                P_SelectedBike.P_HourRate = P_HourlyRate;
                P_SelectedBike.P_DayRate = P_DailyRate;
            }
        }
    }
}
