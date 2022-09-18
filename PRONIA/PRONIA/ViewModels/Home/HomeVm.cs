using System;
using System.Collections.Generic;
using PRONIA.Models;

namespace PRONIA.ViewModels.Home
{
    public class HomeVm
    {
        public HomeVm()
        {
        }
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Service> Services { get; set; }
    }

}
  