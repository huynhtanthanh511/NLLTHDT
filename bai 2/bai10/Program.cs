using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
	class HoursAndMinutes
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			// bài toán tính ra số giờ và số phút 
			int soPhutTong,gio,phut;
			// nhập tổng số phút chúng ta làm được chúng ta có thể quy ra giờ và phút 
			Console.Write("Nhập số phút bạn làm được trong một công việc:");
			soPhutTong = int.Parse(Console.ReadLine());
			// công thức tính ra số giờ 
			gio = soPhutTong / 60;
			// công thức tính ra số phút 
			phut = soPhutTong % 60;
			Console.WriteLine(gio + "giờ" + phut + "phút");
			Console.ReadKey();
		}
	}
}
