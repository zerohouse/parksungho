using System;
	class lab4 {
	static void Main(string[] args)
	{	
		Console.Write("input:");
		string input = Console.ReadLine();
		string[] words = input.Split (' ');
		int[] number = new int[3];
		int i;
		for (i= 0; i<3;i++)
		number[i] = Convert.ToInt32 (words[i]);
		int x=0;
		while (number[0]<number[1])
		{
			x += number[0];
			number[0] +=number[2];
			Console.WriteLine(x);
		}
	}
}


	

	

