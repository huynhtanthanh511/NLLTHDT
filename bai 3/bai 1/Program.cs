using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
	class CheckCredit
	{
		static void Main(string[] args)
		{
			int TienNhap;
			Console.Write("Enter the value of the item you want to buy but from $ 0 => $ 8000:");
			TienNhap = int.Parse(Console.ReadLine());

			if (TienNhap <8000 && TienNhap > 0)
			{
				Console.WriteLine("You entered it correctly.");
			}
			else
				Console.WriteLine("You entered it incorrectly, then enter it again.");
				TienNhap = int.Parse(Console.ReadLine());
				Console.ReadKey();
		}
	}
}
