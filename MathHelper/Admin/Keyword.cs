using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
	public class Keyword
	{
		public int ID { get; set; }
		public String Name { get; set; }

		public Keyword()
		{

		}

		public Keyword(int id, string name)
		{
			ID = id;
			name = Name;
		}

		public static List<Keyword> GetKeywordsByPersonID( int personID )
		{
			List<Keyword> keywords = new List<Keyword>();
			keywords.Add( new Keyword( 1, "Владимир Владимирович" ) );
			keywords.Add( new Keyword( 2, "Путин" ) );
			return keywords;
		}
	}
}
