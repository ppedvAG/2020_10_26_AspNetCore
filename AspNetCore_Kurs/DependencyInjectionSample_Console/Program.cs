using DependencyInjectionSample_Library.BadSample;
using DependencyInjectionSample_Library.GoodSample;
using System;

namespace DependencyInjectionSample_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Altes Beispiel
            DependencyInjectionSample_Library.BadSample.CarService service = new DependencyInjectionSample_Library.BadSample.CarService();
            //Hier wird alles angezeigt, was die Klasse als public angeboten wird. 

            //Car myCar = new Car();
            //myCar.Brand = "VW";
            //myCar.Model = "Polo";
            //myCar.ConstructYear = DateTime.Now;

            //service.RepairCar(myCar);
            #endregion


            #region Besseres Beispiel DI 
            DependencyInjectionSample_Library.GoodSample.CarService testService = new DependencyInjectionSample_Library.GoodSample.CarService();
            testService.AboutUs(); 


            ICarService carService = new DependencyInjectionSample_Library.GoodSample.CarService(); 
            //Gibt die Teilmenge an Methoden, Properties aus, die aus dem ICarService stammen. 


            ICar testCar = new TestCarObject(); //BMW, Z8, 
            //carService.RepairCar(testCar);


            //ICar car = new DependencyInjectionSample_Library.GoodSample.Car();
            //car.Brand = "Porsche";
            //car.Model = "Secial Edition";
            //car.ConstructYear = DateTime.Now;


            //carService.RepairCar(car);

            #endregion
        }
    }
}
