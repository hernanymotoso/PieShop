﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {

        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{ CategoryId=1, CategoryName="Fruit pies", Description="All-fuity pies" },
            new Category{ CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy all the way" },
            new Category{ CategoryId=3, CategoryName="Seasonal pies", Description="Get in the mood for a seasonal pie"}

        };





    }
}
