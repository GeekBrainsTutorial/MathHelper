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
			String userInput = Console.ReadLine();

			if ( userInput == "q" )
			{
				return;
			}

			int number = Int32.Parse( userInput );
			int fact = 1;
			int summ = 0;
			int maxEvenNumber = 0;

			for ( int i = 1; i <= number; i++ )
			{
				fact = fact * i;
				summ = summ + i;
				if ( i % 2 == 0 )
				{
					maxEvenNumber = i;
				}
			}

			Console.WriteLine( "Фактореал равен " + fact );
			Console.WriteLine( "Сумма от 1 до N равна " + summ );
			Console.WriteLine( "максимальное четное число меньше N равно " + maxEvenNumber );



			Console.ReadLine();
		}
	}
}
