using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5b
{
	class CheckMonth2
	{
		static void Main(string[] args)
		{
			int Month, Day;
			Console.Write("Enter your birth day:");
			Day = int.Parse(Console.ReadLine());
			Console.Write("Enter your birth month:");
			Month = int.Parse(Console.ReadLine());

			if (Month >= 1 && Month <= 12)
			{
				if (Day >= 1 && Day <= 31 && (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12))
				{
					Console.WriteLine("Date is valid: " + Day + "/" + Month);
				}
				else
					if (Day >= 1 && Day <= 30 && (Month == 4 || Month == 6 || Month == 9 || Month == 11))
				{
					Console.WriteLine("Date is valid: " + Day + "/" + Month);
				}
				else
					if (Day >= 1 && Day <= 29 && Month == 2)
				{
					Console.WriteLine("Date is valid: " + Day + "/" + Month);
				}
				else

				{
					Console.WriteLine("You entered incorrectly, please re-enter.");
				}

				Console.ReadKey();
			}
		}
	}
}
