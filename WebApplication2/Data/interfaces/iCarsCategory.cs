using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Moduls;

namespace WebApplication2.Data.interfaces
{
    interface iCarsCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
