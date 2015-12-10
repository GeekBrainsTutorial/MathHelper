using System;
using System.Collections.Generic;
using Crawler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
	[TestClass]
	public class UrlFinderTest
	{
		[TestMethod]
		public void UrlsNotFoundTest()
		{
			String html = "<html></html>";
			List<String> urls = new UrlFinder( "lenta.ru" ).GetUrls( "http://lenta.ru", html );
			Assert.AreEqual( urls.Count, 0 );
		}

		[TestMethod]
		public void FindSingleUrl()
		{
			String html = @"<html><body><a href=""http://lenta.ru/1"" /></body></html>";
			List<String> urls = new UrlFinder( "lenta.ru" ).GetUrls( "http://lenta.ru", html );
			Assert.AreEqual( urls.Count, 1 );
			Assert.AreEqual( urls[ 0 ], "http://lenta.ru/1" );
		}

		[TestMethod]
		public void FindMultipleUrl()
		{
			String html = @"<html><body><a href=""http://lenta.ru/1"" />
			<a href=""http://lenta.ru/2"" /></body></html>";
			List<String> urls = new UrlFinder( "lenta.ru" ).GetUrls( "http://lenta.ru", html );
			Assert.AreEqual( urls.Count, 2 );
			Assert.AreEqual( urls[ 0 ], "http://lenta.ru/1" );
			Assert.AreEqual( urls[ 1 ], "http://lenta.ru/2" );
		}

		[TestMethod]
		public void FindOnlyLentaRuUrls()
		{
			String html = @"<html><body><a href=""http://rutrakcer.org/1"" />
			<a href=""http://lenta.ru/2"" /></body></html>";
			List<String> urls = new UrlFinder( "lenta.ru" ).GetUrls( "http://lenta.ru", html );
			Assert.AreEqual( urls.Count, 1 );
			Assert.AreEqual( urls[ 0 ], "http://lenta.ru/2" );
		}

		[TestMethod]
		public void FindUrlsWithDownloading()
		{
			String html = @"<html><body><a href=""http://lenta.ru/1"" /></body></html>";
			String url = "http://lenta.ru";
			IDownloader downloaderMock = new DownloaderMock( html );
			var urls = new UrlFinder( downloaderMock, "lenta.ru" ).GetUrls( url );
			Assert.AreEqual( urls.Count, 1 );
			Assert.AreEqual( urls[ 0 ], "http://lenta.ru/1" );
		}

		/*[TestMethod]
		public void FindUrlsWithDownloading()
		{
			//String url = "http://lenta.ru";
			//new PhraseCountFinder( ).GetCount( html );
		}*/


		/*[TestMethod]
		public void FindRelativeUrls()
		{
			String html = @"<html><body><a href=""4"" />
			<a href=""http://lenta.ru/2"" /></body></html>";
			String url = "http://lenta.ru/1/2/3";
			List<String> urls = new UrlFinder( "lenta.ru" ).GetUrls(url, html );
			Assert.AreEqual( urls.Count, 2 );
			Assert.AreEqual( urls[ 0 ], "http://lenta.ru/1/2/3/4" );
		}*/
	}
}
