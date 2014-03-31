using System;
	class random {
	static void Main(string[] args)
	{	
		int c = 0;
		int d = 0;

	while ( x != c)
	{
		Console.Write("멀까?:");
		string b = Console.ReadLine();
		c = Convert.ToInt32 (b);
		d++;
		if (x>c)
		Console.WriteLine("니가 입력한거 보다 크다");
		else if (x<c)
		Console.WriteLine("니가 입력한거 보다 작다");
		else
	    Console.WriteLine("맞다");

		}
		Console.Write("횟수:{0},답:{1}",d,x);
	
	}
}
