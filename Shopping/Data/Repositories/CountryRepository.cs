using Shopping.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Data.Repositories
{
	public class CountryRepository : GenericRepository<Country>, ICountryRepository
	{
		public CountryRepository(DataContext context) : base(context)
		{
		}
	}

}
