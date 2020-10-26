using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample_Library.GoodSample
{
    public class TestCarObject : ICar // halben Tag arbeit
    {
        public string Brand { get; set; } = "BMW";
        public string Model { get; set; } = "Z8";
        public DateTime ConstructYear { get; set; } = new DateTime(2008, 3, 1);


        public void ShowTestResultOfCar()
        {

        }
    }
}
