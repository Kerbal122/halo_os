using System;

namespace Halo_OS
{
	class MainClass
	{
		public static string name;
		public static void Main (string[] args)
		{
			Console.WriteLine("Thank you for installing Halo_OS.");
			Console.WriteLine ("What is your name?");
			name = Console.ReadLine ();
			if (name == "halo") {
				Console.WriteLine ("His Lordship!");
				Console.ReadKey ();
				halo ();
			} else {
				normal ();
			}
		}

		public static void halo(){
			string choice;
			int i = 0;
			Console.Clear();
			while (i < 10) {
				Console.WriteLine ("King Halo, what can I do for you my lord? ");
				choice = Console.ReadLine ();
				if (choice == "clear") {
					Console.Clear ();
				} else if (choice == "exit") {
					Environment.Exit (1);
				}

			}
		}

		public static void normal(){
			string choice;
			int i = 0;
			Console.Clear ();
			while (i < 100) {
				Console.WriteLine ("What can I do for you " + name + "?");
				choice = Console.ReadLine ();
				if (choice == "clear") {
					Console.Clear ();
				} else if (choice == "exit") {
					Environment.Exit (1);
				}
			}
		}
	}
}
