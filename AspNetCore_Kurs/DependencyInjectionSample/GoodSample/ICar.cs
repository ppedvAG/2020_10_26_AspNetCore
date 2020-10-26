using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample_Library.GoodSample
{
    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }

        DateTime ConstructYear { get; set; }
    }
}
