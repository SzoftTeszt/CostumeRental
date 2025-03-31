using CostumeRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumeRental.Services
{
    public class RentalService
    {
        public List<Costume> Costumes { get; set; } = new List<Costume>();
        public List<Customer> Customers { get; set; } = new List<Customer>();

        internal void AddCostume(Costume costume)
        {
            throw new NotImplementedException();
        }

        internal void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<object> ListAllCostumes()
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<object> ListAvailableCostumes()
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<object> ListCustomers()
        {
            throw new NotImplementedException();
        }
    }
}

