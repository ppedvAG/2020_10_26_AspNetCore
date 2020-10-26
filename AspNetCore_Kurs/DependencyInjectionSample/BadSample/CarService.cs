using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample_Library.BadSample
{
    public class CarService
    {
        public void RepairCar(Car car) //Car = Der Ort der Klasse (mal angenommen liegt in einer anderen DLL), wird immer mitverwendet. 
        {
            //Mach irgendwas mit dem Car-Objekt 
        }
    }




    //CarService benötigt 4 Tage programmieraufwand
    //Car benötigt 8 Tage 
}
