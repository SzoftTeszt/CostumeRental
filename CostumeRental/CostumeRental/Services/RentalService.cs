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

        public void AddCostume(Costume c) {
            Costumes.Add(c);
        } 
        public void AddCustomer(Customer c) {
           Customers.Add(c);
        }
    }
}

