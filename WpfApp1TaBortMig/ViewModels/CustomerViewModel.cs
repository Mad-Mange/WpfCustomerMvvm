using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1TaBortMig.Commands;
using WpfApp1TaBortMig.Models;

namespace WpfApp1TaBortMig.ViewModels
{
    internal class CustomerViewModel
    {
        public CustomerViewModel()
        {
            _customer = new Customer("Mange");
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        private Customer _customer;

        public Customer Customer
        {
            get { return _customer; }
        }

        public ICommand UpdateCommand { get; private set; }
        public bool CanUpdate
        {
            get
            {
                if(Customer == null)
                {
                    return false;
                }
                return !string.IsNullOrWhiteSpace(Customer.Name);
            }
        }

        /// <summary>
        /// Save customer to database or something
        /// </summary>
        public void SaveChanges()
        {
            //Debug.Assert(false, String.Format("{0} was updated.", Customer.Name));
            Debug.Print("{0} was updated.", Customer.Name);
        }

    }
}
