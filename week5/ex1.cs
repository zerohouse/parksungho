﻿using System;
public class ex2 {
	public static void Line(){
		int x = Convert.ToInt32 (Console.ReadLine ());
		for (int i =0; i<x;i++)
			Console.WriteLine("-----------------------");
	}
	static void Main(string[] args) {
		Console.Write ("number? ");
		Line();
		Console.Write ("Another Number?");
		Line ();
		Console.WriteLine ("End");
	}
}
