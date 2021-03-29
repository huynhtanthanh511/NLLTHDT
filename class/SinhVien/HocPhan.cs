using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
	class HocPhan
	{
		public string maSoHocPhan;
		public string tenHocPhan;
		public byte soTinChi;
		public bool batBuocVaTuChon;

		public void NhapHocPhan()
		{
			Console.Write("Ma hoc phan:");
			maSoHocPhan = Console.ReadLine();
			Console.Write("Ten hoc phan:");
			tenHocPhan = Console.ReadLine();
			Console.Write("So tin chi:");
			soTinChi = byte.Parse(Console.ReadLine());
			Console.Write("nhap (1:bat buoc; 2:tu chon\n");
			batBuocVaTuChon = Console.ReadLine()=="1"?true:false; 
		}
		public void Xuat()
		{
			Console.WriteLine("{0}",batBuocVaTuChon );
		}
	}
}
