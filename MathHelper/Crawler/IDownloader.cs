using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crawler
{
	public interface IDownloader
	{
		String Download( String url );
	}
}
