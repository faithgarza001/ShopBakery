using System;
namespace DemoShopCafe.Models
{
	public class MockCategoryRepository : ICategoryRepository
	{
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category { CategoryId = 1, CategoryName = "Fruit Pies", Description = "All-fruity pies"},

            new Category { CategoryId = 2, CategoryName = "Cheese Cakes", Description = "All-Cheese Cake" },

            new Category {  CategoryId = 3, CategoryName = "Seasonal Pies", Description = "All Holiday pies"}
        };
    }
}

