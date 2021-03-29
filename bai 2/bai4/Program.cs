using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDecimalTest
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 45;
			float b= 0.5f;
			float c = (float)a;
			int d = (int)b;
			Console.WriteLine("c={0}\n d={1}",c,d );
			Console.ReadKey();
			// nếu ép sai kiểu thì nó sẽ trở về số null
		}
	}
}
