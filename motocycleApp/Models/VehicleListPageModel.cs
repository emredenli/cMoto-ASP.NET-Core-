using motocycle.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motocycleApp.Models
{
    public class VehicleListPageModel
    {
        public VehicleListPageModel()
        {
            VehicleDetailPageModels = new List<VehicleDetailPageModel>();
            Brands = new List<Brand>();
            Categories = new List<Category>();
        }

        public List<VehicleDetailPageModel> VehicleDetailPageModels { get; set; }

        public List<Brand> Brands { get; set; }

        public List<Category> Categories { get; set; }

        public string Title { get; set; }
        public string Search { get; set; }
        public int BrandId { get; set; }

        public int CategoryId { get; set; }
    }
}
