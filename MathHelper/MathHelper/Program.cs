using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
	class Program
	{
		static const string _symbolForExit = "-q";

		static void Main( string[] args )
		{
			try
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
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine("Что-то пошло не так. Экстренный выход");
			}
			Console.ReadLine();
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

		private static bool TryGetNumberFromUser(out int number)
		{
			Console.WriteLine( "Здравствуйте, вас приветствует математическая программа" );
			Console.WriteLine( "Пожалуйста, введите число. Для выхода введите " + _symbolForExit );
			string userInput = Console.ReadLine();
			while(!Int32.TryParse(userInput, out number))
			{
				if ( userInput == _symbolForExit )
				{
					number = -1;
					return false;
				}
				else
					Console.WriteLine( "Вы ввели неправильное значение. Пожалуйста, введите именно число. Для выхода нажмите " + _symbolForExit );

				userInput = Console.ReadLine();
			}
			return true;

			//number = Int32.Parse( userInput );
			//return Int32.TryParse(userInput, out number);

		}
	}
}
