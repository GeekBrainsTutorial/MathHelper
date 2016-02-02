using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
	public class FakeRepotoryFactory : IRepositoryFactory
	{
		public ISitesRepository GetSitesRepository()
		{
			return new FakeSitesRepository();
		}

		public IKeywordsRepository GetKeywordsRepository()
		{
			return new FakeKeywordsRepository();
		}
	}
}
