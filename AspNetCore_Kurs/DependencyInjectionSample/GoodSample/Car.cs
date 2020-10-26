using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample_Library.GoodSample
{
    public class Car : ICar // 8 Tage
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ConstructYear { get; set; }


        //Noch mehr interne Methoden/Logik etc. 
    }
}
