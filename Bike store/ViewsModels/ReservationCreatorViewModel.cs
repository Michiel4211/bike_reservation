using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_store.ViewsModels
{
    class ReservationCreatorViewModel
    {
        //Save variables
        public Store P_Store { get; set; }
        public Reservation P_SelectedReservation { get; set; }
        public RelayCommand P_SaveReservation { get; set; }
        public RelayCommand P_Delete { get; set; }
        public RelayCommand P_Edit { get; set; }

        //Input variables
        public double P_HourlyRate { get; set; }
        public Bike P_SelectedBike { get; set; }
        public string P_Enddate { get; set; }
        public string P_Startdate { get; set; }
        public Store P_Storelocation { get; set; }
        public Customer P_Customerid { get; set; }
        public E_PaymentStatuss P_PaymentStatus { get; set; }

        public ReservationCreatorViewModel()
        {
            Init();
        }

        //Initializes all content on the window
        private void Init()
        {
            P_SaveReservation = new RelayCommand(SaveRev);
            P_Edit = new RelayCommand(Edit);
            P_Delete = new RelayCommand(Delete);
        }

        //To-do Create the reservation and add it to the store
        private void SaveRev(object sender)
        {        
            Reservation resevation = new Reservation();
            
            resevation.P_ReservationID = P_Store.P_ReservationList.Count;
            resevation.P_EndDate = P_Enddate;
            resevation.P_StartDate = P_Startdate; 
            resevation.P_ReservedBikes.Add(P_SelectedBike);
            resevation.P_PaymentStatus = P_PaymentStatus;
            resevation.P_StoreLocation = P_Storelocation;
            resevation.P_CustomerID = P_Customerid;

            P_Store.P_ReservationList.Add(resevation);
        }

        //Delete an excisting selected store from the Listbox
        private void Delete(object sender)
        {
            if (P_SelectedReservation != null)
            {
                P_Store.P_ReservationList.Remove(P_SelectedReservation);
            }
        }

        //Edit an excisting selected store from the Listbox
        private void Edit(object sender)
        {
            if (P_SelectedReservation != null)
            {
                P_SelectedReservation.P_ReservationID = P_Store.P_ReservationList.Count;
                P_SelectedReservation.P_EndDate = P_Enddate;
                P_SelectedReservation.P_StartDate = P_Startdate;
                P_SelectedReservation.P_ReservedBikes.Add(P_SelectedBike);
                P_SelectedReservation.P_PaymentStatus = P_PaymentStatus;
                P_SelectedReservation.P_StoreLocation = P_Storelocation;
                P_SelectedReservation.P_CustomerID = P_Customerid;
            }
        }
    }
}
