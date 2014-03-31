using System;
	class sum {
	static void Main(string[] args)
	{		
		int a = 0;
		int c = 0;
		int d = 0;
		while ( a != -1)
		{
		Console.Write("suja:");
			string b = Console.ReadLine();
		a = Convert.ToInt32 (b);
		c++;
		d += a;
		}
		Console.Write("갯수:{0},합:{1}",c,d);
		a = d / c;
		Console.WriteLine(" 평균:{0}",a);
	}
}
