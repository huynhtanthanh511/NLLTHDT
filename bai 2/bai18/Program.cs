using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18
{
	class PigLatin 
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			string Word, Latin, firstLetter;
			Console.Write("Nhập tên: ");
			Word = Console.ReadLine();
			firstLetter = Word.Substring(0, 1);
			Word = Word.Substring(1);
			Latin = Word + firstLetter + "ay";
			Console.WriteLine("Tên bạn kiểu PigLatin là: " + Latin);
			Console.ReadKey();
		}
	}
}
