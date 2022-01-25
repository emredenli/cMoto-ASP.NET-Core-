using System;
using System.Collections.Generic;
using System.Text;

namespace motocycle.Data.Model
{
    public class Dimension
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int DistanceBetweenWheels { get; set; }
        public int SeatHeight { get; set; }
        public decimal FuelCapacity { get; set; }
        public int Weight { get; set; }
    }
}
