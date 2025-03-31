using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumeRental.Models
{
    public class Customer
    {
        

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public List<Costume> RentedCostumes { get; set; } = new List<Costume>();


        public Customer(int customerID, string name)
        {
            CustomerID = customerID;
            Name = name;

        }

        public override string? ToString()
        {
            return $"{CustomerID} - {Name}";
        }
    }
}
    
    