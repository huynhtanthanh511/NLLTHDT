using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai 1
{
	class PhanSo
	{
		public int tu;
		public int mau;
		/*public void Enter()
		{
			Console.Write("Enter death:");
			death = int.Parse(Console.ReadLine());
			Console.Write("Enter form:");
			form = int.Parse(Console.ReadLine());
		}*/
		public void Export()
		{
			Console.WriteLine("{0}/{1}", tu,mau);
		}

	
		public PhanSo()
		{
			mau = 1;
		}
		public PhanSo (int t , int m)
		{
			tu = t;
			mau= m;
		}
		public PhanSo Cong(PhanSo a, PhanSo b)
		{
			PhanSo kq = new PhanSo();
			kq.tu = a.tu * b.mau + b.tu * a.mau;
			kq.mau = a.mau * b.mau;
			return kq;
		}
	}
}
