using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
	class EggsInteractive
	{
		static void Main(string[] args)
		{
			// nhập số trứng chưa biết trước và quy đổi 
			Console.OutputEncoding = Encoding.UTF8;
			int SoTrung;
			Console.Write("Nhập số trứng muốn quy đổi:");
			SoTrung = int.Parse(Console.ReadLine());
			int MotChuc, TrungGa;
			// một tá gồm 12 trứng
			MotChuc = SoTrung / 12;
			TrungGa = SoTrung % 12;
			Console.WriteLine(MotChuc + " chục\n" + TrungGa + " quả trứng");
			Console.ReadKey();
		}
	}
}
