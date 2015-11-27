using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
	class KeywordViewer
	{
		public void View(int personID)
		{
			FakeKeywordsRepository keywordRepo = new FakeKeywordsRepository();
			var keywords = keywordRepo.GetKeywordsByPersonID( personID );
			foreach(var keyword in keywords)
			{
				Console.WriteLine( keyword.Name );
			}
		}
	}
}
