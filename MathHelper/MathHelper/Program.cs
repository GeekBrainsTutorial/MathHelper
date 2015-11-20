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
			int number;
			if ( TryGetNumberFromUser( out number ) )
			{
				int fact, summ, maxEvenNumber;
				CalculateFactorialAndSummAndMaxEventNumber( number, out fact, out summ, out maxEvenNumber );

				// Выводим результаты на консоль
				Console.WriteLine( "Факториал равен " + fact );
				Console.WriteLine( "Сумма от 1 до N равна " + summ );
				Console.WriteLine( "Максимальное четное число меньше N равно " + maxEvenNumber );
				Console.ReadLine();
			}
		}

		private static void CalculateFactorialAndSummAndMaxEventNumber( int number, out int fact, out int summ, out int maxEvenNumber )
		{
			fact = 1;
			summ = 0;
			maxEvenNumber = 0;

			for ( int i = 1; i <= number; i++ )
			{
				fact = fact * i;
				summ = summ + i;
				if ( i % 2 == 0 )
				{
					maxEvenNumber = i;
				}
			}
		}

		private static bool TryGetNumberFromUser(out int number)
		{
			Console.WriteLine( "Здравствуйте, вас приветствует математическая программа" );
			Console.WriteLine( "Пожалуйста, введите число." );
			String userInput = Console.ReadLine();

			if ( userInput == "q" )
			{
				number = -1;
				return false;
			}

			number = Int32.Parse( userInput );
			return true;
		}
	}
}
