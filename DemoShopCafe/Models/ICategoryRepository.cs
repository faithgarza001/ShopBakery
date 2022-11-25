using System;
namespace DemoShopCafe.Models
{
	public interface ICategoryRepository
	{
        public IEnumerable<Category> AllCategories { get; }
    }
}

