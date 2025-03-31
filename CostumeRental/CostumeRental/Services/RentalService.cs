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
        public List<Costume> ListAllCostumes() {
            return this.Costumes.ToList();
        }


        public List<Customer> ListCustomers() { 
            return this.Customers.ToList();
        }
        public List<Costume> ListAvailableCostumes() { 
            return this.Costumes.FindAll(x=>x.IsAvailable);
        }

        public bool RentCostume(string name, string id) { 
            Customer customer = Customers.Find(x=>x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            Costume costume = Costumes.Find(x => x.CostumeID == id);
            if (customer != null && costume != null
                && costume.IsAvailable)
            {
                costume.IsAvailable = false;
                customer.RentedCostumes.Add(costume);
                return true;            
            }
            return false;
        }

        public void RemoveCostume(string id) {
            Costumes.RemoveAll(x=>x.CostumeID.Equals(id));
        }


    }
}

