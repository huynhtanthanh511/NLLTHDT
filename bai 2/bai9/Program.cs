using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.OutputEncoding = Encoding.UTF8;
			int hours, miles, sum = 200, tongCongTatCa;
			Console.Write("Nhập số giờ:");
			hours = int.Parse(Console.ReadLine());
			Console.Write("Nhập số dặm:");
			miles = int.Parse(Console.ReadLine());
			tongCongTatCa = sum * ((hours * 150) + (miles * 2));
			Console.WriteLine("Tổng số tiền cần trả là:" + tongCongTatCa);
			Console.ReadKey();
		}
	}
}
