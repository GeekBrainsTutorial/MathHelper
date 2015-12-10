using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
	public class Downloader : IDownloader
	{
		public String Download( String url )
		{
			using(var httpClient = new HttpClient())
			{
				return httpClient.GetStringAsync( url ).Result;
			}
		}
	}
}
