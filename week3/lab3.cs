using System;
	class gugudan {
	static void Main(string[] args)
	{	
		int c;
		
		Console.Write("숫자:");
		string a = Console.ReadLine();
		int b = Convert.ToInt32(a);
		     for (int i=1;i<10;i++)
			{
				c = i * b;
		Console.WriteLine("{0}*{1}={2}",b,i,c);
	}
	}
	
}
