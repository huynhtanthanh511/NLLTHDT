using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
	class Hurricane
	{
		static void Main(string[] args)
		{
			byte TheWindSpeed;
			//the wind speed: là tốc độ gió 
			Console.Write("please enter the wind speed:");
			TheWindSpeed = byte.Parse(Console.ReadLine());
			//miles per hour: dặm trên giờ 
			Console.WriteLine(TheWindSpeed + " miles per hour");
			if (TheWindSpeed >= 150)
			{
					// Category 5 hurricanes: cơn bảo cấp số 5
					Console.WriteLine("Category 5 hurricanes ");
					}
					if (TheWindSpeed < 150 && TheWindSpeed >= 130)
					{
						Console.WriteLine("Category 4 hurricanes");
					}
					if (TheWindSpeed < 130 && TheWindSpeed >= 111)
					{
						Console.WriteLine("Category 3 hurricanes");
					}
					if (TheWindSpeed < 111 && TheWindSpeed >= 96)
					{
						Console.WriteLine("Category 2 hurricanes");
					}
					if (TheWindSpeed < 96 && TheWindSpeed >= 74)
					{
						Console.WriteLine("Category 1 hurricanes");
					}
			
			else 
			if (TheWindSpeed<74)
			{
				Console.WriteLine("Not a hurricane");
			}
			Console.ReadKey();
		}
	}
}
