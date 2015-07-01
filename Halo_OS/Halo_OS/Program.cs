using System;

namespace Halo_OS
{
	class MainClass
	{
		public static string name;
		public static DateTime now = DateTime.Now;
		public static void Main (string[] args)
		{
			Console.WriteLine("Thank you for installing Halo_OS.");
			Console.WriteLine ("What is your name?");
			name = Console.ReadLine ();
			if (name == "halo") {
				Console.WriteLine ("His Lordship!");
				Console.ReadKey ();
				normal ();
			} else {
				normal ();
			}
		}


		public static void normal(){
			//strings
			string choice;
			string lines;
			string read;
			string time;
			//ints
			int num = 0; // num is the number of times that the section can be called, seeing as it is never added to. It will go on forever, SO DONT ADD A num++
			int times = 1;

			Console.Clear ();
			//this while statement is basically the entire program.
			while (num < 100) {
				
				//these four lines are just asking the most basic parts. 
				Console.WriteLine (now + " Account: " + name);
				Console.WriteLine ("What can I do for you?");
				choice = Console.ReadLine ();

				/*TODO add a cls for clear screen as well
				 * More options?
				 * user  test?
				 * Add more cool features
				 * GUI?
				 */

				//this is where the actual code is.
				if (choice == "clear") { 
					// first is just a simple clear screen.
					Console.Clear ();
				} 

				else if (choice == "exit") {
					// Lets you exit the os/asistant.
					Environment.Exit (1);
				} 

				else if (choice == "diary") {
					/* Now for some real code.
					 * First, we write a few lines for the diary, so that people can write what they want
					 * TODO MAKE IT SO THAT THE FILE DOESNT OVERWRITE THE OLD ONE.
					 * 
					 */
					Console.Clear ();
					lines = Console.ReadLine ();
					times = Convert.ToInt32 (System.IO.File.ReadAllText (@"C:\Users\Halo\Desktop\Diary\times.txt"));
					// Make sure to change this line when you compile it to where you want to put your diary
					times++;
					time = Convert.ToString (times);
					System.IO.File.WriteAllText (@"C:\Users\Halo\Desktop\Diary\Diary.txt", lines);
					System.IO.File.WriteAllText (@"C:\Users\Halo\Desktop\Diary\times.txt", time);
					Console.Clear ();
				} 

				else if (choice == "read") {
					// This reads form the Diary
					//TODO ADD THE ABILITY TO PICK WHICH DIARY TO READ... ITS A BUG.
					read = System.IO.File.ReadAllText(@"C:\Users\Halo\Desktop\Diary\Diary.txt");
					Console.WriteLine (read);
					Console.ReadKey ();
					Console.Clear();
				}
			}
		}
	}
}
