using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.interfaces;
using WebApplication2.Data.Moduls;

namespace WebApplication2.Data.mocks
{
    public class MockCars : IAllcars
    {
        private readonly iCarsCategory _categoryCars = new MocksCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { name = "Tesls", available = true, Category = _categoryCars.AllCategories.Last() }
                };
            }

        }
        public IEnumerable<Car> getFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
