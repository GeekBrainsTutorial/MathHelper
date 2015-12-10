using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
	class DbRepositoryFactory : IRepositoryFactory
	{
		public ISitesRepository GetSitesRepository()
		{
			return new DbSitesRepository();
		}

		public IKeywordsRepository GetKeywordsRepository()
		{
			return new DbKeywordsRepository();
		}
	}
}
