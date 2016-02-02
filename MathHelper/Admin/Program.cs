using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Admin
{
	class Program
	{
		static void Main( string[] args )
		{
			var container = RegisterDIContainer();
			IKeywordsRepository keywordRepo = container.Resolve<IKeywordsRepository>();
			KeywordViewer viewer = new KeywordViewer( keywordRepo );
			viewer.View(1);
		}

		private static IContainer RegisterDIContainer()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<FakeKeywordsRepository>().As<IKeywordsRepository>();
			return builder.Build();
		}

	}
}
