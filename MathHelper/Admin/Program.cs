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
			List<Keyword> keywords = Keyword.GetKeywordsByPersonID( 1 );
		}
	}
}
