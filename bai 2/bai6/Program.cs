using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
	class InchesToCentimeterslnteractive
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			// const được sử dụng để khai báo biến hằng của bất kỳ kiểu dữ liệu nào

			const double CentimeterInInch = 2.54;

			double centimet,inch;
			//string nhap;
			Console.Write("nhập giá trị inch từ bàn phím:");
			inch = double.Parse(Console.ReadLine());
			Console.WriteLine("inch có giá trị là:" + inch);
			centimet = inch * CentimeterInInch;
			Console.WriteLine("kq:la {0}", centimet);
			//Console.WriteLine(inch + " inch \n" + centimet + " centimet.");
			Console.ReadKey();

		}
	}
}
