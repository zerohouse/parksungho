using System;

namespace cal
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] g;
			g = new string[1];
			string x;
			int b;
			int c;
			Console.Write (" su:");
			x = Console.ReadLine ();

			g = x.Split (' ');

			c = Convert.ToInt32 (g [0]);
			b = Convert.ToInt32 (g [1]);

			int[] j;
			j = new int[13];
			j [0] = 0;
			j [1] = 31;
			j [2] = 28;
			j [3] = 31;
			j [4] = 30;
			j [5] = 31;
			j [6] = 30;
			j [7] = 31;
			j [8] = 31;
			j [9] = 30;
			j [10] = 31;
			j [11] = 30;
			j [12] = 31;



			int wer = 0;
			for (int i = 0; i < c; i++)
				wer +=	j [c];

			int sw = (wer + b) % 7;
			if (sw == 1) {
				Console.Write ("fri");
			} else if (sw == 2) {
				Console.Write ("sat");
			} else if (sw == 3) {
				Console.Write ("sun");
			}
			else if (sw==4){
				Console.Write ("mon");}
			else if (sw==5){
				Console.Write ("tue");}
			else if (sw==6){
				Console.Write ("wed");}
			else {
				Console.Write ("thr");}
		}}}




























