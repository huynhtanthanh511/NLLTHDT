using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bai5
{
	class InchesToCentmeters
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			// const được sử dụng để khai báo biến hằng của bất kỳ kiểu dữ liệu nào

			const double CentimeterInInch = 2.54;

			double centimet, inch = 3;


			centimet = inch * CentimeterInInch;
			
			Console.WriteLine(inch + " inch \n" + centimet + " centimet.");
		}
	}
}
