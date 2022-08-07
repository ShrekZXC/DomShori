using System.Collections.Generic;
using DomShori.Interface;
using DomShori.Models;

namespace DomShori.Mocks
{
    public class MockCategory : ICurtainsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Шторы"},
                new Category { categoryName = "Другие Категории" }

                };
            }
        }
    }
}
