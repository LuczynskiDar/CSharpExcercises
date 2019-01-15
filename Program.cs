using System;
using System.Diagnostics;
using System.Threading;

namespace CSharpExcercises
{
    class Program
    {
        // the number of philosophers
		public const int NUM_PHILOSOPHERS = 5;

        // the chopsticks, implemented as sync objects
		public static object[] chopstick = new object[NUM_PHILOSOPHERS];

		// the philosophers, implemented as threads
		public static Thread[] philosopher = new Thread[NUM_PHILOSOPHERS];


        static void Main(string[] args)
        {
 
			// set up the dictionary that measures total eating time
			for (int i = 0; i < NUM_PHILOSOPHERS; i++)
			{
			
               Philosophers.eatingTime.Add (i, 0);
			}

			// set up the chopsticks
			for (int i = 0; i < NUM_PHILOSOPHERS; i++)
			{
				chopstick [i] = new object ();
			}

			// set up the philosophers
			for (int i = 0; i < NUM_PHILOSOPHERS; i++)
			{
				int index = i;
				object chopstick1 = chopstick [i];
				object chopstick2 = chopstick [(i + 1) % NUM_PHILOSOPHERS];
				philosopher [i] = new Thread( _ =>
					{
						Philosophers.DoWork (index, chopstick1, chopstick2);
					}
				);
			}

			// start the philosophers
			Philosophers.stopwatch.Start ();
			Console.WriteLine ("Starting philosophers...");
			for (int i = 0; i < NUM_PHILOSOPHERS; i++)
			{
				philosopher [i].Start ();
			}

			// wait for all philosophers to complete
			for (int i = 0; i < NUM_PHILOSOPHERS; i++)
			{
				philosopher [i].Join ();
			}
			Console.WriteLine ("All philosophers have finished");

			// report the total time spent eating
			int total_eating_time = 0;
			for (int i = 0; i < NUM_PHILOSOPHERS; i++)
			{
				Console.WriteLine ("Philosopher {0} has eaten for {1}ms", i, Philosophers.eatingTime [i]);
				total_eating_time += Philosophers.eatingTime [i];
			}
			Console.WriteLine ("Total time spent eating: {0}ms", total_eating_time);
			Console.WriteLine ("Optimal time spent eating: {0}ms", Philosophers.stopwatch.ElapsedMilliseconds * 2);
        }
    }
}
