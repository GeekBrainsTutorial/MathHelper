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
		String _host;
		IDownloader _downloader;


		public UrlFinder( IDownloader downloader, String host )
			:this(host)
		{
			_downloader = downloader;
		}

		public UrlFinder( String host )
		{
			_host = host;
		}

		public List<String> GetUrls(string url, string html )
		{
			// @"<html><body><a class="css-link" href=""http://lenta.ru/1""></body></html>"
			var match = Regex.Matches( html, @"(?<=a href="").*?(?="")", RegexOptions.Singleline );
			if ( match.Count != 0 )
			{
				var result = new List<string>();
				foreach ( var m in match )
				{
					Uri newUrl = new Uri( new Uri( url ), m.ToString() );
					if ( newUrl.Host == _host )
					{		
						result.Add( newUrl.OriginalString );
					}					
				}
				return result;
			}
			else
				return new List<String>();
		}

		public List<String> GetUrls( string url )
		{
			String html = _downloader.Download( url );
			return GetUrls( url, html );
		}
	}
}
