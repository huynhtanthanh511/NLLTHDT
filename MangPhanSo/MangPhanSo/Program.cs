using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangPhanSo
{
	class Program
	{
		enum Menu
		{
			Exit = 10,
			Input = 1,
			Output = 2,
			SeachMax,
			SeachByDenominator
		}
		static void Main(string[] args)
		{
			MangPhanSo ds = new MangPhanSo();
			
			
			
			// tìm số lớn nhất
			//PhanSo kq = ds.SeachMax();
			//Console.Write("max:");
			//kq.Output();
			// tìm tất cả các số có phần tử là x 
			//ds.FindAllFractionsWhoseDenominatorIs(5).OutputArray();
			//ds.CountAllNegativeFraction().OutputArray();

			while (true)
			{
				Console.WriteLine("Import to {0} exit",(int)Menu.Exit);
				Console.WriteLine("Import to {0} import from file: " , (int)Menu.Input);
				Console.WriteLine("Import to {0} output",(int)Menu.Output);
				Menu menu = (Menu)int.Parse(Console.ReadLine());
				switch (menu)
				{
					case Menu.Exit: return;
					case Menu.Input:
						//ds.InputArray();
						//ds.ImportFromFile();
						ds.RadomEntry();
						ds.OutputArray();
						break;
					case Menu.Output:
						ds.OutputArray();
						break; 
				}
			}
		}
	}
}
