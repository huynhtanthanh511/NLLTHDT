using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
	class CPU
	{
		public string ten;
		public string hang;
		public int giaTien;
		public int namSX;
		public int tocDo;
		public void NhapThongTin()
		{
			Console.Write("ten mat hang:");
			ten = Console.ReadLine();
			Console.Write("hang:");
			hang = Console.ReadLine();
			Console.Write("Gia tien");
			giaTien = int.Parse(Console.ReadLine());
			Console.Write("ma san pham");
			namSX= int.Parse(Console.ReadLine());
			Console.Write("");
			tocDo = int.Parse(Console.ReadLine());
		}

	}
}
