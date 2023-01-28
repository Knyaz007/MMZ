using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Moduls;

namespace WebApplication2.Data.interfaces
{
    interface IAllcars
    {
        IEnumerable<Car> Cars {get;}
        IEnumerable<Car> getFavCars { get; set; }
        Car getObjectCar(int carId);
    }
}
