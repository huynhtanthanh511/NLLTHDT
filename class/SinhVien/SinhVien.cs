using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
	class SinhVien
	{
		public int maSoSinhVien;
		public DateTime ngayThangNamSinh;
		public string hoTen;
		public string queQuan;
		public void NhapSinhVien()
		{
			Console.Write("Ma so sinh vien:");
			maSoSinhVien = int.Parse(Console.ReadLine());
			Console.Write("Ngay thang nam sinh:");
			ngayThangNamSinh = DateTime.Parse(Console.ReadLine());
			Console.Write("Ho ten:");
			hoTen =Console.ReadLine().ToString();
			Console.Write("Que quan:");
			queQuan = Console.ReadLine().ToString();
		}
	}
}
