using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
	class DbKeywordsRepository : IKeywordsRepository
	{
		public List<Keyword> GetKeywordsByPersonID( int personID )
		{
			// TODO: get keywords from database
			return new List<Keyword>();
		}
	}
}
