using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
	class MakeChange
	{
		static void Main(string[] args)
		{
			// bài quy đổi tiền thành tờ 10 ngàn, 5 ngàn và 2 ngàn 
			Console.OutputEncoding = Encoding.UTF8;
			int SoTienQuyDoi;
			Console.Write("Nhập số tiền bạn muốn quy đổi:");
			SoTienQuyDoi = int.Parse(Console.ReadLine());
			int MuoiNgan = SoTienQuyDoi / 10;
			// hàm remain lấy số dư để chia tiếp 
			int Remain10 = SoTienQuyDoi % 10;
			int NamNgan = Remain10 / 5;
			int Remain5 = Remain10 % 5;
			int HaiNgan = Remain5 / 2;
			Console.WriteLine(MuoiNgan + " tờ mười ngàn \n" + NamNgan + "tờ năm ngàn.\n" + HaiNgan + "tờ hai ngàn.");
			Console.ReadKey();
		}
	}
}
