using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangPhanSo
{
	class PhanSo
	{
		public int nummerator;
		public int denominator;
		public void Input()
		{
			Console.Write("Enter Nummerator:");
			nummerator = int.Parse(Console.ReadLine());
			Console.Write("Enter Denominator:");
			denominator = int.Parse(Console.ReadLine());
		}
		public void Output()
		{
			Console.WriteLine("{0}/{1}", nummerator, denominator);
		}


		public PhanSo()
		{
			denominator = 1;
		}
		public PhanSo(int t, int m)
		{
			nummerator = t;
			denominator = m;
		}
		public PhanSo Cong(PhanSo a, PhanSo b)
		{
			PhanSo kq = new PhanSo();
			kq.nummerator = a.nummerator * b.denominator + b.nummerator * a.denominator;
			kq.denominator = a.denominator * b.denominator;
			return kq;
		}
	}
}
