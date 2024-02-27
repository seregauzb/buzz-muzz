/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld
{
  static void Main ()
  {
	while (true)
	  {

		Console.WriteLine ("Please enter digit for continue or string \"exit\" for exit");

		string integer = Console.ReadLine ();
		if (integer == "exit")
		  {
			break;
		  }

		if (!CheckInt (integer))
		  {
			Console.WriteLine ("You need enter digit");
			continue;
		  }

		int c = int.Parse (integer);

		if (c % 3 == 0 && c % 5 == 0)
		  {

			Console.WriteLine ("fizz-buzz");

		  }
		else if (c % 5 == 0)
		  {

			Console.WriteLine ("fizz");

		  }
		else if (c % 3 == 0)
		  {

			Console.WriteLine ("buzz");

		  }
		else
		  {
			Console.WriteLine (c);
		  }


	  }
  }
  public static bool CheckInt (string inputs)
  {

	int otvet;
	return int.TryParse (inputs, out otvet);

  }
}

