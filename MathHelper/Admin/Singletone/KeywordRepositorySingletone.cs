using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
	static class KeywordRepositorySingletone
	{
		static IKeywordsRepository _instance;
		static Object _obj = new object();

		public static IKeywordsRepository GetInstance()
		{
			if(_instance == null)
			{
				lock( _obj )
				{
					if(_instance == null)
					{
						_instance = new FakeKeywordsRepository();
					}						
				}				
			}
			return _instance;
		}
	}
}
