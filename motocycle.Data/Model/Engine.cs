using System;
using System.Collections.Generic;
using System.Text;

namespace motocycle.Data.Model
{
    public class Engine
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string EngineType { get; set; }
        public int EngineCapacity { get; set; }
        public decimal CylinderDiameter { get; set; }
        public decimal Strok { get; set; }
        public string CompressionRate { get; set; }
        public string FuelSystem { get; set; }
        public string MaximumPower { get; set; }
        public string maximumTorque { get; set; }
        public string Ignition { get; set; }
        public string Transmission { get; set; }
        public string PowerTransmission { get; set; }
    }
}
