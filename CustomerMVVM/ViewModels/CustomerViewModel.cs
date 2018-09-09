using CustomerMVVM.Commands;
using CustomerMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CustomerMVVM.ViewModel
{
    class CustomerViewModel
    {
        private Customer _Customer;
        public Customer Customer
        {
            get { 
                return _Customer;
            }
        }

        public CustomerViewModel()
        {
            _Customer = new Customer("David");
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        public void SaveChanges()
        {
            MessageBox.Show("save to server " + Customer.Name);
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }
        public bool CanUpdate {
            get
            {
                return Customer != null && !string.IsNullOrWhiteSpace(Customer.Name);
            }
        }
    }
}
