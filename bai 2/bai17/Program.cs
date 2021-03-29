using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai17
{
	class planet
	{
		//PlanetsInTheSolarSystem : các hành tinh trong hệ mặt trời 
		// Em vân thắt mắt cách in vừa tạo ra tên bằng tiếng vietj và tên tiếng anh của các hành tinh ra 
		enum PlanetsInTheSolarSystem 
		{
			Mercury=1,
			Venus,
			Earth,
			Mars,
			Jupiter,
			Saturn,
			Uranus,
			Neptune,
		}
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			int Planet;
			Console.Write("Nhập 1=>8 để hiển thị tên hành tinh: ");
			Planet = int.Parse(Console.ReadLine());
			Console.WriteLine("Hành tinh bạn nhập là:" + (PlanetsInTheSolarSystem)Planet);
			Console.ReadKey();


		}
	}
}
