using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumeRental.Models
{
    public class Customer
    {
        private int v1;
        private string v2;

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public List<Costume> RentedCostumes { get; set; } = new List<Costume>();

        public Customer(int customerID, string name, List<Costume> rentedCostumes)
        {
            CustomerID = customerID;
            Name = name;
            RentedCostumes = rentedCostumes;
        }

        public Customer(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
