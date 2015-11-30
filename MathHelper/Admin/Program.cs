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
			FakeKeywordsRepository keywordRepo = new FakeKeywordsRepository();
			//List<Keyword> keywords = keywordRepo.GetKeywordsByPersonID( 1 );
			KeywordViewer viewer = new KeywordViewer( keywordRepo );
			viewer.View(1);
		}
	}
}
