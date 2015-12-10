using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crawler;

namespace Test
{
	public class DownloaderMock : IDownloader
	{

		String _html;

		public DownloaderMock( String html )
		{
			_html = html;
		}

		#region IDownloader Members

		public string Download( string url )
		{
			return _html;
		}

		#endregion
	}
}
