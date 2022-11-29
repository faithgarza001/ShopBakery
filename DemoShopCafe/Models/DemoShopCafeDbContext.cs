using System;
using Microsoft.EntityFrameworkCore;

namespace DemoShopCafe.Models
{
	public class DemoShopCafeDbContext : DbContext
	{
		public DemoShopCafeDbContext(DbContextOptions<DemoShopCafeDbContext> options) : base(options)
		{
		}
	}
}

