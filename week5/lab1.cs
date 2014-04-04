using System;
class ex1 {
	static void Main(string[] args)
	{	
		Console.Write("반복횟수를 입력하세요:");
		string a = Console.ReadLine();
		int b = Convert.ToInt32(a);
			for (int i=b;i>0;i--)
			{


			for (int k=0; i>k;k++)
				Console.Write(" ");

			for (int j=2*b; i*2 -1<j;j--)
					Console.Write("*");


				Console.WriteLine();
			}
		}
	}
	





