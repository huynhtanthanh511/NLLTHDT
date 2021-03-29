using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
	class MonthNames
	{
		enum month
		{
			January=1,
			February=2,
			March=3,
			April=4,
			May=5,
			June=6,
			July=7,
			August=8,
			September=9,
			October=10,
			November=11,
			December=12,
		}
		static void Main(string[] args)
		{
			int Thang;
			Console.OutputEncoding = Encoding.UTF8;
			Console.Write("Nhập số tháng từ 1=>12 mà bạn muốn chuyên đổi thành tiếng anh:");
			Thang= int.Parse(Console.ReadLine());
			Console.WriteLine("thang:"+Thang+"=>"+(month)Thang);
			Console.ReadKey();
		}
	}
}
