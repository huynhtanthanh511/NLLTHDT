using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
	class Program
	{
		static int[] a = new int[100];
		static int length = 0;

		static void Main(string[] args)
		{
			int lengthkq = 0;
			Input();
			Output(a, length);
			Console.ReadLine();
			//// tìm phàn tử lớn nhất
			//int max = SeachElementMax();
			//Console.Write("the larget eleman array is: " + max);
			//// tìm phần tử nhỏ nhất
			//int min = SeachElementMin();
			//Console.Write("the smallest eleman array is: " + min);
			//// tìm tất cả các số âm
			//Console.Write("Find all negative numbers:");
			//int[] negative = FindAllNegativeNumbers(ref lengthkq);
			//Output(negative, lengthkq);
			//// tìm tất cả các số dương
			//Console.Write("Find all positive numbers:");
			//int[] positive = FindAllPositiveNumbers(ref lengthkq);
			//Output(positive, lengthkq);
			//// tìm tất cả các số chẵn
			//int[] even = FindAllEvenNumbers(ref lengthkq);
			////Output(even, lengthkq);
			//int[] possible = FindAllPossibleNumbers(ref lengthkq);
			//Output(possible, lengthkq);
			//int[] prime = FindAllPrimeNumbers(ref lengthkq);
			//Output(prime, lengthkq);
			int[] timphantu = FindTheMostFrequentlyOccurringItem(ref lengthkq);
			Output(timphantu, lengthkq);


			Console.ReadKey();
		}
		// hàm nhập xuất 
		static void Input()
		{
			Console.Write("Enter the an array of section:");
			length = int.Parse(Console.ReadLine());
			Random r = new Random();
			for (int i = 0; i < length; i++)
			{
				a[i] = r.Next(-10, 10);
			}
		}
		static void Output(int[] mang, int soPhanTu)
		{
			Console.Write("");
			for (int i = 0; i < soPhanTu; i++)
			{
				Console.Write(" " + mang[i]);
			}
		}

		// Tìm số lớn nhất
		static int SeachElementMax()
		{
			int Max = a[0];
			for (int i = 1; i < length; i++)
			{
				if (a[i] > Max)
				{
					Max = a[i];
				}
			}
			return Max;
		}
		// Tìm số nhỏ nhất 
		static int SeachElementMin()
		{
			int Min = a[0];
			for (int i = 1; i < length; i++)
			{
				if (a[i] < Min)
				{
					Min = a[i];

				}
			}
			return Min;
		}
		// Tìm tất cả các số âm 
		static int[] FindAllNegativeNumbers(ref int lengthkq)
		{
			int[] Negative = new int[100];
			for (int i = 0; i < length; i++)
			{
				if (a[i] < 0)
					Negative[lengthkq++] = a[i];
			}
			return Negative;
		}
		//  Tìm tất cả các số dương
		static int[] FindAllPositiveNumbers(ref int lengthkq)
		{
			int[] Positive = new int[100];
			for (int i = 0; i < length; i++)
			{
				if (a[i] > 0)
					Positive[lengthkq++] = a[i];
			}
			return Positive;
		}
		// tìm tất cả các số chẵn 
		static int[] FindAllEvenNumbers(ref int lengthkq)
		{
			int[] Even = new int[100];
			for (int i = 0; i < length; i++)
			{
				if (a[i] % 2 == 0)
					Even[lengthkq++] = a[i];
			}
			return Even;
		}
		// tìm tất cả các số lẻ
		static int[] FindAllPossibleNumbers(ref int lengthkq)
		{
			int[] Possible = new int[100];
			for (int i = 0; i < length; i++)
			{
				if (a[i] % 2 != 0)
					Possible[lengthkq++] = a[i];
			}
			return Possible;
		}
		// tìm tất cả các số nguyên to
		// tìm tất cả các số không chia hết cho số nhỏ hơn nó 
		static int[] FindAllPrimeNumbers(ref int lengthkq)
		{
			int[] Prime = new int[100];
			for (int i = 0; i < length; i++)
				if (a[i] > 1)
				{
					bool flag = false;
					for (int j = 2; j < a[i]; j++)
					{
						if (a[i] % j == 0)
							flag = true;
					}
					if (!flag)
						Prime[lengthkq++] = a[i];
				}
			return Prime;
		}
		// tìm phần tử xuất hiện nhiều nhất
		static int[] FindTheMostFrequentlyOccurringItem(ref int lengthkq)
		{
			int[] kq = new int[100];

			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length; j++)
				{

				}
			}
			
			return kq;
		}



	}
}
