using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample_Library.GoodSample
{
    public class CarService : ICarService // 4 Tage 
    {
        public void RepairCar(ICar car) //Alle Objekte können als Parameter verwendet werden, die ein ICar als Interface implementiert haben.
        {
            //Mach irgendwas mit car


            Console.Write($"Marke {car.Brand} Modell {car.Model} erbaut in {car.ConstructYear.ToShortDateString()}");
        }

        public void AboutUs()
        {

        }
    }

    
}
