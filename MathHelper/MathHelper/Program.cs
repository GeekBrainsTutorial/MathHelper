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
				//int fact, summ, maxEvenNumber;
				//CalculateFactorialAndSummAndMaxEventNumber( number, out fact, out summ, out maxEvenNumber );

				GetFactorialAndOutput( number );
				GetSummFrom1ToNAndOutput( number );
				GetMaxEvenNumberAndOutput( number );
				
				Console.ReadLine();
			}
		}

		private static void GetMaxEvenNumberAndOutput( int number )
		{
			int maxEvenNumber = 0;

			for ( int i = 1; i <= number; i++ )
			{
				if ( i % 2 == 0 )
				{
					maxEvenNumber = i;
				}
			}
			Console.WriteLine( "Максимальное четное число меньше N равно " + maxEvenNumber );
		}

		private static void GetSummFrom1ToNAndOutput( int number )
		{
			int summ = 0;

			for ( int i = 1; i <= number; i++ )
			{
				summ = summ + i;
			}
			Console.WriteLine( "Сумма от 1 до N равна " + summ );
		}

		private static void GetFactorialAndOutput( int number )
		{
			int fact = 1;
			for ( int i = 1; i <= number; i++ )
			{
				fact = fact * i;
			}
			Console.WriteLine( "Факториал равен " + fact );
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
