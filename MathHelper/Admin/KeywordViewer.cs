using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
	class KeywordViewer
	{
		private IKeywordsRepository _keywordRepo;

		public KeywordViewer(IKeywordsRepository keywordRepo)
		{
			_keywordRepo = keywordRepo;
		}

		public void View( int personID )
		{
			var keywords = _keywordRepo.GetKeywordsByPersonID( personID );
			foreach(var keyword in keywords)
			{
				Console.WriteLine( keyword.Name );
			}
		}
	}
}
