using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SinhVien
{
	
	class ThueBao
	{
		public int soDienThoai;
		public string tenKhachHang;
		public string diaChi;
		public void NhapThueBao()
		{
			Console.Write("So dien thoai");
			soDienThoai = int.Parse(Console.ReadLine());
			Console.Write("Ten khach hang:");
			tenKhachHang = Console.ReadLine();
			Console.Write("Dia Chi:");
			diaChi = Console.ReadLine();
		}
	}
}
