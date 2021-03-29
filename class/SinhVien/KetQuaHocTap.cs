using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
	class KetQuaHocTap
	{
		public byte diem;

		public void NhapKetQua()
		{	
			Console.Write("Diem:");
			diem = byte.Parse(Console.ReadLine());
		}
	}
}
