using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.interfaces;
using WebApplication2.Data.Moduls;

namespace WebApplication2.Data.mocks
{
    public class MocksCategory : iCarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category> {
                new Category { categoryName ="ilectric avto",desc="fdss"},
                new Category { categoryName ="'classic avto",desc="fdss"}

                };

            }
        }
    }
}
