using System;
using System.Collections.Generic;
using System.Text;

namespace motocycle.Data.Model
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        

    }
}
