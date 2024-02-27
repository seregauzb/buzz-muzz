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
		integer="";
		if (c % 7 == 0)
		{
		      if(integer!=""){
			    integer+="-guzz";
		      }else{
		          integer+="guzz";
		      }

		}
		if (c % 5 == 0)
		{

			if(integer!=""){
			    integer+="-buzz";
		      }else{
		          integer+="buzz";
		      }

		}
		if (c % 4 == 0)
		{

			if(integer!=""){
			    integer+="-muzz";
		      }else{
		          integer+="muzz";
		      }

		}
		if (c % 3 == 0){
		    
			if(integer!=""){
			    integer+="-fizz";
		      }else{
		          integer+="fizz";
		      }

		}
		
		if(integer!=""){
		    Console.WriteLine(integer);
		}else{
		    Console.WriteLine(c);
		}

	}
  }
public static bool CheckInt (string inputs)
{

	int otvet;
	return int.TryParse (inputs, out otvet);

}
}
