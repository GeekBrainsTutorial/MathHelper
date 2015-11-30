using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
	class FakeKeywordsRepository : IKeywordsRepository
	{
		public List<Keyword> GetKeywordsByPersonID( int personID )
		{
			List<Keyword> keywords = new List<Keyword>();
			keywords.Add( new Keyword { ID = 1, Name = "Владимир Владимирович" } );
			keywords.Add( new Keyword { ID = 2, Name = "Путин" } );
			return keywords;
		}
	}
}
