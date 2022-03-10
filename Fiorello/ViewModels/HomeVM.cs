using Fiorello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public SliderData SliderData { get; set; }
    }
}
