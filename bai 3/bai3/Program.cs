using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
	class Admission
	{
		static void Main(string[] args)
		{
			double userInPut1, userInPut2;
			// có một cách khác nữa là chúng ta cho thêm một biến string và ép kiểu cho nó để trở thành ddouble nhưng cách đó khá là dài d
			Console.WriteLine("Please enter your point grade average");
			userInPut1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter your admission test score");
			userInPut2 = double.Parse(Console.ReadLine());

				if ((userInPut1 >= 3.0 && userInPut2 >= 60)|| (userInPut1 < 3.0 && userInPut2 >= 80))
					{
						Console.WriteLine("You are accepted, congratulations!");
							return;
					}
				
				else
					{
						Console.WriteLine(" Sorry, but you do not meet requirements ");
					}
			Console.ReadKey();

		}
	}
}
