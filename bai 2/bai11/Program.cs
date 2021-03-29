using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11
{
	class Eggs
	{
		static void Main(string[] args)
		{
			// tính tổng trứng gà của 4 con và quy về tá và quả trứng thu được(với số quả trứng biết trước) 
			Console.OutputEncoding = Encoding.UTF8;
			int trungGaTrungBinhCuaMoiCon = 50, tong;
			tong = 50 * 4;
			Console.WriteLine("Tổng số trứng gà của 4 con:"+tong);			
			int motChuc, trungGa;
			// một tá gồm 12 trứng
			motChuc = tong / 12;
			trungGa = tong % 12;
			Console.WriteLine(motChuc + " chục\n" + trungGa + " quả trứng");
			Console.ReadKey();
		}
	}
}
