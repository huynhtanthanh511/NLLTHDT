using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
	class CheckMonth
	{
		static void Main(string[] args)
		{
			int Month;
			Console.Write("Enter your birth month:");
			Month = int.Parse(Console.ReadLine());
			if (Month >= 1 && Month <= 12) 
			{
				Console.WriteLine("you entered correctly.\nMonth=>" + Month);
			}
			else
			{
				Console.WriteLine("You entered incorrectly, please re-enter.");
			}
			Console.ReadKey();
		}
	}
}
