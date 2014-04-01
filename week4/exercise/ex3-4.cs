using System;
class ex3 {
	static void Main(string[] args)
	{	
		int i = 6;
		int j;
		do
		{	i--;
			j=6;
			do
			{
			j--;
			Console.Write("*");
			}
			while(i<j);
			Console.WriteLine();
		}
		while (i>1);
	}
}


	

	

