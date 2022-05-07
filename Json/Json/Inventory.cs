using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    public class Inventory
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }

        public List<Inventory> GetProducts()
        {
            return new List<Inventory>()
            {
                new Inventory{Name = "Rice", Price = 20, Weight = 10},
                new Inventory{Name = "Wheat", Price = 30, Weight = 5},
                new Inventory{Name = "Pulses", Price = 50, Weight = 3}
            };

        }
    }
}
