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
			IRepositoryFactory repoFactory = new FakeRepotoryFactory();
			IKeywordsRepository keywordRepo = repoFactory.GetKeywordsRepository();
			KeywordViewer viewer = new KeywordViewer( keywordRepo );
			viewer.View(1);
		}
	}
}
