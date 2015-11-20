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
				int fact = GetFactorial( number );
				int summ = GetSummFrom1ToN( number );
				int maxEvenNumber = GetMaxEvenNumber( number );

				Console.WriteLine( "Факториал равен " + fact );
				Console.WriteLine( "Сумма от 1 до N равна " + summ );
				Console.WriteLine( "Максимальное четное число меньше N равно " + maxEvenNumber );
				Console.ReadLine();
			}
		}

		private static int GetMaxEvenNumber( int number )
		{
			int maxEvenNumber = 0;

			for ( int i = 1; i <= number; i++ )
			{
				if ( i % 2 == 0 )
				{
					maxEvenNumber = i;
				}
			}
			return maxEvenNumber;
		}

		private static int GetSummFrom1ToN( int number )
		{
			int summ = 0;

			for ( int i = 1; i <= number; i++ )
			{
				summ = summ + i;
			}
			return summ;
		}

		private static int GetFactorial( int number )
		{
			int fact = 1;
			for ( int i = 1; i <= number; i++ )
			{
				fact = fact * i;
			}
			return fact;
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
			Console.WriteLine( "Пожалуйста, введите число. Для выхода введите q" );
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
