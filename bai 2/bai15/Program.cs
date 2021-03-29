using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15
{
	class FahrenheitToCelsius
	{
		static void Main(string[] args)
		{
			// bài này em vẫn chưa thể làm được cho nó bằng 2 chữ số thập phân 
			Console.OutputEncoding = Encoding.UTF8;
			decimal f;
			Console.Write("nhập độ f:");
			f = decimal.Parse(Console.ReadLine());
			decimal C;
			C = (f - 32) * 5 / 9;
			decimal.Round(C,2);
			Console.WriteLine("độ C="+C);
			Console.ReadKey();
		}
	}
}
