using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
	class Twitter
	{
		static void Main(string[] args)
		{
			//Console.OutputEncoding = Encoding.UTF8;
			string message;
				Console.WriteLine("Enter a Twitter message here: ");
				message = Console.ReadLine();
				int howLong = message.Length;
				if (howLong > 140)
					Console.WriteLine("The message is too long");
				else
					Console.WriteLine("The message is okay");

			}
	}
}
