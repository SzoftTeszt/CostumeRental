using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumeRental.Models
{
    public class Costume
    {
        public string CostumeID { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Theme { get; set; }
        public bool IsAvailable { get; set; } = true;
        public decimal PricePerDay { get; set; }

        public Costume(string id, string name, string size, string theme, decimal price)
        {
            CostumeID = id;
            Name = name;
            Size = size;
            Theme = theme;
            PricePerDay = price;
        }

        public override string? ToString()
        {
            return $"{CostumeID}: {Name} ({Size}, {Theme}, {PricePerDay}";
        }
    }
}
