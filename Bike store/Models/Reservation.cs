using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_store
{
    public class Reservation : INotifyPropertyChanged
    {
        private int _ReservationID;
        private Customer _CustomerID;
        private string _StartDate;
        private string _EndDate;
        private E_PaymentStatuss _PaymentStatus;
        private Store _StoreLocation = new Store();
        private ObservableCollection<Bike> _ReservedBikes = new ObservableCollection<Bike>();

        //Public variables you can use and set
        public int P_ReservationID { get => _ReservationID; set => _ReservationID = value; }
        public Customer P_CustomerID { get => _CustomerID; set => _CustomerID = value; }
        public Store P_StoreLocation { get => _StoreLocation; set => _StoreLocation = value; }
        public ObservableCollection<Bike> P_ReservedBikes { get => _ReservedBikes; set => _ReservedBikes = value; }
        public string P_StartDate { get => _StartDate; set => _StartDate = value; }
        public string P_EndDate { get => _EndDate; set => _EndDate = value; }

        public E_PaymentStatuss P_PaymentStatus { get => _PaymentStatus; set => _PaymentStatus = value; }

        public event PropertyChangedEventHandler PropertyChanged;


        //Notify function
        public void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }         
   }
    //Private Enum settings Only public for acces purposes not for setting value
    public enum E_PaymentStatuss
    {
        Unpayed,
        payed,
        Error
    }
}
