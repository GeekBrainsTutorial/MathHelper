using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Crawler
{
	public class UrlFinder
	{
		Downloader _downloader = new Downloader();
		
		public UrlFinder( )
		{
		}

		public List<String> GetUrls( string url )
		{
			String html = _downloader.Download( url );
					
			var match = Regex.Matches( html, @"(?<=a href="").*?(?="")", RegexOptions.Singleline );
			var result = new List<string>();
			foreach ( var m in match )
			{
				Uri newUrl = new Uri( new Uri( url ), m.ToString() );
				result.Add( newUrl.OriginalString );
			}
			return result;
		}
	}
}
