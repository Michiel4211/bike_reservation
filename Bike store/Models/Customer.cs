using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_store
{
    public class Customer : INotifyPropertyChanged
    {
        private int _CustomerID;
        private string _CustomerName;
        private E_CustomerGender _CustomerGender;
        private string _CustomerMail;
        private ObservableCollection<Reservation> _Reservations = new ObservableCollection<Reservation>();

        //Public variables you can use and set
        public int P_CustomerID { get => _CustomerID; set => _CustomerID = value; }
        public string P_CustomerName {
            get => _CustomerName;
            set {
                _CustomerName = value;
                Notify("P_CustomerName");
            }
        }
        public E_CustomerGender P_CustomerGender { get => _CustomerGender; set => _CustomerGender = value; }
        public string P_CustomerMail { get => _CustomerMail; set => _CustomerMail = value; }
        public ObservableCollection<Reservation> P_ReservationList { get => _Reservations; set => _Reservations = value; }

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
    public enum E_CustomerGender
    {
        Male,
        Female
    }
}
