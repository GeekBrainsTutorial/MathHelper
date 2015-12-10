using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
	interface IRepositoryFactory
	{
		ISitesRepository GetSitesRepository();

		IKeywordsRepository GetKeywordsRepository();
	}
}
