using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
	public class FakeSitesRepository : ISitesRepository
	{
		public String GetSiteNameByID(int id)
		{
			return "lenta.ru";
		}
	}
}
