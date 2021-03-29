using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MangPhanSo
{
	class MangPhanSo
	{
		public PhanSo[] a = new PhanSo[100];
		public int length=0;
		// nhập mảng phân số
		public void InputArray()
		{
			Console.Write(" Enter length array:");
			length = int.Parse(Console.ReadLine());
			for (int i=0;i<length;i++)
			{
				a[i] = new PhanSo();
				a[i].Input();
			}
		}
		// xuất phân số từ mảng 
		public void OutputArray()
		{
			for (int i=0;i<length;i++)
			{
				a[i].Output();
			}
		}
		//thêm phân số
		public void Them(PhanSo x)
		{
			a[length] = x;
			length++;
		}
		// nhập từ file txt
		public	void ImportFromFile()
		{
			string path = @"data.txt";
			StreamReader sr = new StreamReader(path);
			string s = "";
			while ((s=sr.ReadLine())!=null)
				{
				string[] tam = s.Split('/');
				int tu = int.Parse(tam[0]);
				int mau = int.Parse(tam[1]);
				Them(new PhanSo(tu, mau));
			}
		}
		// hàm nhập ngẫu nhiên 
		public void RadomEntry()
		{
			Console.Write("Enter length array:");
			length = int.Parse(Console.ReadLine());
			Random r = new Random();
			for (int i=0;i<length;i++)
			{
				a[i] = new PhanSo(r.Next(10), r.Next(1,10));
			}
		}
		public PhanSo SeachMax()
		{
			PhanSo max = new PhanSo(int.MinValue,1);
			for (int i=0; i<length;i++)
			{
				float x = (float)a[i].nummerator / a[i].denominator;
				float y = (float)max.nummerator / max.denominator;
				if (x > y)
					max = a[i];
			}
			return max;
		}
		// tìm tất cả các phân số có mẫu là x
		public MangPhanSo FindAllFractionsWhoseDenominatorIs(int x)
		{
			MangPhanSo kqmau = new MangPhanSo();
			for (int i=0; i<length;i++)
			{
				if (a[i].denominator == x)
					kqmau.Them(a[i]);
			}
			return kqmau;
		}
		// đêm các phân số âm trong mảng 
		//public MangPhanSo CountAllNegativeFraction()
		//{
		//	int demAm=0;
		//	for (int i = 0; i < length; i++)
		//	{
		//		if (a[i] < 0)
		//			demAm += 1;
		//		demAm++;
		//	}
		//}

	}
}
