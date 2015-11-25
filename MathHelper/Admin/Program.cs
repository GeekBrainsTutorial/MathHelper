using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
	class Program
	{
		static void Main( string[] args )
		{
			KeywordsRepository keywordRepo = new KeywordsRepository();
			List<Keyword> keywords = keywordRepo.GetKeywordsByPersonID( 1 );
		}
	}
}
