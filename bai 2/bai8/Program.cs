using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			const int SoPhanTramTangtrongNamToi = 4;
			int nv=0;
			Console.Write("Người dùng tự nhập tiền lương vào đây:");
			nv =int.Parse(Console.ReadLine());
			Console.WriteLine("Số tiền lương mà người dùng nhập vào là:"+nv);
			int SoLuongNamToi;
			SoLuongNamToi = (100* nv)/SoPhanTramTangtrongNamToi;
			Console.WriteLine("Số tiền của nhân viên trong năm tới là:" + SoLuongNamToi);
			Console.ReadKey();
		}
	}
}
