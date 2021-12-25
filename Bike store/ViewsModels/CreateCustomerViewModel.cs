using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_store.ViewsModels
{
    class CreateCustomerViewModel
    {
        public Store P_Store { get; set; }
        public Customer P_SelectedCustomer { get; set; }
        public RelayCommand P_SaveCustomer { get; set; }
        public RelayCommand P_Delete { get; set; }
        public RelayCommand P_Edit { get; set; }

        //Input text
        public string P_CustomerName { get; set; }
        public E_CustomerGender P_CustomerGender { get; set; }
        public string P_CustomerMail { get; set; }

        public CreateCustomerViewModel()
        {
            Init();
        }

        //Initializes all content on the window
        private void Init()
        {
            P_SaveCustomer = new RelayCommand(Save);
            P_Edit = new RelayCommand(Edit);
            P_Delete = new RelayCommand(Delete);
        }

        //Creates bike and adds it to the shop
        private void Save(object sender)
        {
            Customer customer = new Customer();

            customer.P_CustomerID = P_Store.P_CustomerList.Count;
            customer.P_CustomerName = P_CustomerName;
            customer.P_CustomerGender = P_CustomerGender;
            customer.P_CustomerMail = P_CustomerMail;

            P_Store.P_CustomerList.Add(customer);
        }

        //Delete an excisting selected store from the Listbox
        private void Delete(object sender)
        {
            if (P_SelectedCustomer != null)
            {
                P_Store.P_CustomerList.Remove(P_SelectedCustomer);
            }
        }

        //Edit an excisting selected store from the Listbox
        private void Edit(object sender)
        {
            if (P_SelectedCustomer != null)
            {
                P_SelectedCustomer.P_CustomerID = P_Store.P_CustomerList.Count;
                P_SelectedCustomer.P_CustomerName = P_CustomerName;
                P_SelectedCustomer.P_CustomerGender = P_CustomerGender;
                P_SelectedCustomer.P_CustomerMail = P_CustomerMail;
            }
        }
    }
}
