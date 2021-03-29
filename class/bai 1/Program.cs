using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace bai 1
{
	class Program
	{
		static void Main(string[] args)
		{
			
			
			/*PhanSo a = new PhanSo();
			a.Export();
			a.Enter();
			a.Export();
			PhanSo b = new PhanSo();
			b.Export();
			b = a;
			b.Export();*/
			PhanSo a = new PhanSo(2 , 3);
			a.Export();
			PhanSo b = new PhanSo(4, 4);
			b.Export();
			PhanSo c = a.Cong(a, b);
			c.Export();
			Console.ReadKey();
		}

	}
}
