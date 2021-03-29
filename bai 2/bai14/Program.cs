using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai14
{
	class TestsInteractive
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			decimal toan = 8.5m, ly = 8.6m, hoa = 8.3m, van = 8.2m, anh = 8;
			decimal tinhTrungBinh = (toan + ly + hoa + van + anh) / 5;
			Math.Round(tinhTrungBinh, 2);
			Console.WriteLine("Điểm trung bình là:" + tinhTrungBinh);
			Console.ReadKey();
			// có 2 cách chuyển đổi thập phân 
			// một là dùng decimal.Round nhưng tất cả biến đều phải là decimal
			// hai là dùng Math.round cách này thì có thể dùng cho tất cả các loại biến 
		}
	}
}
