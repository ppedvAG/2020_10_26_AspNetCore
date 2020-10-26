using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample_Library.GoodSample
{
    public interface ICarService
    {
        void RepairCar(ICar car);
    }
}
