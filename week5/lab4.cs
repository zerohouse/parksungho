using System;

namespace Next {
	public class Next {
		public static int[] ReadInts(string msg){
			int[] arr;
			arr = new int[3];
			Console.Write ("{0}", msg);
			string x = Console.ReadLine ();


			string[] words = x.Split (' ');
			for (int i =0; i!=3;i++)
				arr [i] = Convert.ToInt32 (words [i]);



			return arr;
		}
	}

	class Test{
		static void Main(string[] args){
			int[] arr = Next.ReadInts ("input test Numbers : ");
			foreach (int i in arr)
				Console.WriteLine (i);
		}
	}
}