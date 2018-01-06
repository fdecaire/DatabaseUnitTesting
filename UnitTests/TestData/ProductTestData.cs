using System.Collections.Generic;
using Repository.Models;

namespace UnitTests.TestData
{
    public static class ProductTestData
    {
	    public static List<Product> Get(int dataSetNumber)
	    {
		    switch (dataSetNumber)
		    {
			    case 1:
				    return new List<Product>
				    {
					    new Product
					    {
						    Id = 0,
						    Store = 1,
						    Name = "Cheese",
						    Price = 2.5m
					    },
					    new Product
					    {
						    Id = 1,
						    Store = 1,
						    Name = "Crackers",
						    Price = 1.25m
					    },
					    new Product
					    {
						    Id = 2,
						    Store = 1,
						    Name = "Beef",
						    Price = 5m
					    },
					    new Product
					    {
						    Id = 3,
						    Store = 1,
						    Name = "Milk",
						    Price = 1.2m
					    },
					    new Product
					    {
						    Id = 4,
						    Store = 1,
						    Name = "Cereal",
						    Price = 3.5m
					    },
					    new Product
					    {
						    Id = 5,
						    Store = 1,
						    Name = "Orange Juice",
						    Price = 3m
					    },
					    new Product
					    {
						    Id = 6,
						    Store = 1,
						    Name = "Carrots",
						    Price = 1.3m
					    },
					    new Product
					    {
						    Id = 7,
						    Store = 1,
						    Name = "Apple",
						    Price = 0.5m
					    },
					    new Product
					    {
						    Id = 8,
						    Store = 1,
						    Name = "Onion",
						    Price = 0.45m
					    },
					    new Product
					    {
						    Id = 9,
						    Store = 1,
						    Name = "Salmon",
						    Price = 4.25m
					    },
					    new Product
					    {
						    Id = 10,
						    Store = 1,
						    Name = "Chicken",
						    Price = 2.25m
					    },
					    new Product
					    {
						    Id = 11,
						    Store = 1,
						    Name = "Salt",
						    Price = 1.57m
					    },
					    new Product
					    {
						    Id = 12,
						    Store = 1,
						    Name = "Sugar",
						    Price = 3.24m
					    }

				    };
			    case 2:
				    return new List<Product>
				    {
				    };
		    }
		    return null;
	    }
    }
}
