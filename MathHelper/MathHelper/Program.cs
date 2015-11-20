using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Здравствуйте вас приветствует математическая программа" );
			Console.WriteLine( "пажалуйста введите число." );
			String S = Console.ReadLine();

			if ( S == "q" )
			{
				return;
			}

			int M = Int32.Parse( S );
			int c1 = 1;
			int c2 = 0;
			int c3 = 0;

			for ( int i = 1; i <= M; i++ )
			{
				c1 = c1 * i;
				c2 = c2 + i;
				if ( i % 2 == 0 )
				{
					c3 = i;
				}
			}

			Console.WriteLine( "Фактореал равен " + c1 );
			Console.WriteLine( "Сумма от 1 до N равна " + c2 );
			Console.WriteLine( "максимальное четное число меньше N равно " + c3 );



			Console.ReadLine();
		}
	}
}
