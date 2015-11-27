using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mean
{
	class Program
	{
		const String ARITHMETIC_MEAN_CMD = "-am";
		const String GEOMETHRIC_MEAN_CMD = "-gm";
		const int CMD_POSITION = 0;				// position of command name in argument list
		const int ARRAY_POSITION = 1;			// position of first array element in argument list

		static void Main( string[] args )
		{
			try
			{
				String command = GetCommandName( args );
				List<int> numberArray = GetNumberArray( args );

				if ( numberArray != null && command == ARITHMETIC_MEAN_CMD )
				{
					Console.WriteLine( GetArithmeticMean( numberArray ) );
				}
				else if ( numberArray != null && command == GEOMETHRIC_MEAN_CMD )
				{
					Console.WriteLine( GetGeomethricMean( numberArray ) );
				}
				else
					ShowWarning();
			}
			catch
			{
				Console.WriteLine("Failed to calculate");
			}
			Console.WriteLine( "Press ENTER for exit" );
			Console.ReadLine();
		}

		private static void ShowWarning()
		{
			Console.WriteLine( "Please, run probram with following arguments:\n" +
				"-am <number list> - calculate arithmeic mean for numbers from list.\n"  +
				"                    Use only positive numbers. Example: -am 1 2 3 4 5\n" +
				"-gm <number list> - calculate geomethric mean for numbers from list.\n" +
				"                    Use only positive numbers. Example:, -gm 3 3 3" );
		}

		private static double GetGeomethricMean( List<int> numberArray )
		{
			double result = 1;
			foreach ( int num in numberArray )
			{
				result *= num;
			}
			return Math.Pow( result, 1.0 / numberArray.Count );
		}

		private static double GetArithmeticMean( List<int> numberArray )
		{
			if ( numberArray == null )
				return 0;

			double result = 0;
			foreach(int num in numberArray)
			{
				result += num;
			}
			return result / numberArray.Count;
		}

		private static List<int> GetNumberArray( string[] args )
		{
			if(args.Length < ARRAY_POSITION + 1)
				return null;

			List<int> result = new List<int>();
			int number;
			for(int i = ARRAY_POSITION; i < args.Length; i++)
			{
				if ( Int32.TryParse( args[ i ], out number ) )
					result.Add( number );
				else
					return null;
			}
			return result;
		}

		private static string GetCommandName( string[] args )
		{
			if ( args.Length < CMD_POSITION + 1 )
				return null;
			else
				return args[ CMD_POSITION ];
		}
	}
}
