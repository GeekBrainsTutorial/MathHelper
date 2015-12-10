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
			KeywordViewer viewer = new KeywordViewer( KeywordRepositorySingletone.GetInstance() );
			viewer.View(1);
		}
	}
}
