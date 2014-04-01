using System;
class ex1 {
	static void Main(string[] args)
	{	
		Console.Write("반복횟수를 입력하세요:");
		string a = Console.ReadLine();
		int b = Convert.ToInt32(a);
		if (b<=0)	{
			Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
		}
			else{
		for (int i=b;i>0;i--)
		{
			for (int j=b+1; i!=j;j--)
			Console.Write("*");
			Console.WriteLine();
		}
			}
	}

}


	

	

