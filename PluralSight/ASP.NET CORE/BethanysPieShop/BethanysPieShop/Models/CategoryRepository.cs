﻿namespace BethanysPieShop.Models
{
	public class CategoryRepository : ICategoryRepository
	{
		public readonly BethanysPieShopDbContext _bethanysPieShopDbContext;

		public CategoryRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
		{
			_bethanysPieShopDbContext = bethanysPieShopDbContext;
		}

		public IEnumerable<Category> AllCategories => _bethanysPieShopDbContext.Categories.OrderBy(p => p.CategoryName);
     
	}
}
