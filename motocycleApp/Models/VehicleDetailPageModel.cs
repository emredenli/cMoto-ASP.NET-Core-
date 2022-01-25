using motocycle.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motocycleApp.Models
{
    public class VehicleDetailPageModel
    {
        public VehicleDetailPageModel()
        {
            Dimension = new Dimension();
            Engine = new Engine();
            Vehicle = new Vehicle();
            Image = new Image();
        }

        public Vehicle Vehicle { get; set; }
        public Dimension Dimension { get; set; }
        public Engine Engine { get; set; }
        public Image Image { get; set; }
    }
}
