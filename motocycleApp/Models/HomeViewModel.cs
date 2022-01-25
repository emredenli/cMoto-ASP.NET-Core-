using motocycle.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motocycleApp.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Notifications = new List<Notification>();
        }

        public List<Notification> Notifications { get; set; }
    }
}
