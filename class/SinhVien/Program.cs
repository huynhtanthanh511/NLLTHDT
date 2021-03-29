using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
	class Program
	{
		static void Main(string[] args)
		{
			//SinhVien a = new SinhVien();
			//a.NhapSinhVien();
			//HocPhan b = new HocPhan();
			//b.NhapHocPhan();
			//KetQuaHocTap c = new KetQuaHocTap();
			//c.NhapKetQua();
			//ThueBao d = new ThueBao();
			//d.NhapThueBao();
			CPU e = new CPU();
			e.NhapThongTin();

			Console.ReadKey();
		}
	}
}
