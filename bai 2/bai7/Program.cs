using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			const int SoPhanTramTangtrongNamToi=4;
			int nv1 = 2000000, nv2 = 3000000, nv3 = 4000000;
			Console.Write(" Nhân viên 1 có số lương là:{0}\n Nhân viên 2 có số lương là{1}\n Nhân viên 3 có số lương là:{2}", nv1, nv2, nv3);
			int SoLuongNamToi1,SoLuongNamToi2,SoLuongNamToi3;
			SoLuongNamToi1 = (nv1 * 100) / SoPhanTramTangtrongNamToi;
			Console.WriteLine("\nSố lương của nhân viên 1 năm tới " + SoLuongNamToi1);
			SoLuongNamToi2 = (nv2*100)/SoPhanTramTangtrongNamToi;
			Console.WriteLine("Số lương của nhân viên 2 năm tới là:" + SoLuongNamToi2);
			SoLuongNamToi3 = (nv3 * 100) / SoPhanTramTangtrongNamToi;
			Console.WriteLine("Số lương của nhân viên năm 3 năm tới là:" + SoLuongNamToi3);
		}
	}
}
