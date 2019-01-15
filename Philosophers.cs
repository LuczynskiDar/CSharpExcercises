using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace CSharpExcercises
{
    public class Philosophers
    {
        
		// maximum amount of time spent thinking, in milliseconds
		public const int THINK_TIME = 10;

		// maximum amount of time spent eating, in milliseconds
		public const int EAT_TIME = 10;

		// the timeout for locking a chopstick, in milliseconds
		public const int LOCK_TIMEOUT = 15;

		// recovery time when a chopstick lock fails
		public const int RECOVERY_TIME = 15;

		// total program runtime in milliseconds
		public const int RUN_TIME = 10000;

		// a shared stopwatch to abort the program after a specific timeout
		public static Stopwatch stopwatch = new Stopwatch ();

		// a shared dictionary to measure how many philosophers have eaten
		public static Dictionary<int, int> eatingTime = new Dictionary<int, int>();

		// a sync object to protect access to the eating field
		public static object eatingSync = new object();

        public Philosophers()
        {
        }

        // this method lets the philosopher think
        public static void Think()
		{
			Random random = new Random();
			Thread.Sleep (random.Next (THINK_TIME));
		}

		// this method lets the philosopher eat
		public static void Eat (int index)
		{
			Random random = new Random();
			int time_spent_eating = random.Next (EAT_TIME);
			Thread.Sleep (time_spent_eating);

			// log our total eating time
			lock (eatingSync)
			{
				eatingTime [index] += time_spent_eating;
			}
		}

		// the philosopher work method - think and eat until timeout
		public static void DoWork (int index, object chopstick1, object chopstick2)
		{
			do
			{
				bool lockTaken1 = false;
				bool lockTaken2 = false;

				// only think after a successful prior eat, otherwise retry eat
				if (lockTaken1 && lockTaken2)
				{
					Think ();
				}

				try
				{
					// lock first chopstick, random sleep if lock times out
					Monitor.TryEnter (chopstick1, LOCK_TIMEOUT, ref lockTaken1);
					if (lockTaken1)
					{
						try
						{
							// lock second chopstick, random sleep if lock times out
							Monitor.TryEnter (chopstick2, LOCK_TIMEOUT, ref lockTaken2);
							if (lockTaken2)
							{
								Eat (index);
							}
							else
							{
								Random random = new Random ();
								int time_spent_eating = random.Next (RECOVERY_TIME);
								Thread.Sleep (time_spent_eating);
							}
						}
						finally
						{
							if (lockTaken2)
								Monitor.Exit (chopstick2);
						}
					}
					else
					{
						Random random = new Random ();
						int time_spent_eating = random.Next (RECOVERY_TIME);
						Thread.Sleep (time_spent_eating);
					}
						
				}
				finally
				{
					if (lockTaken1)
						Monitor.Exit (chopstick1);
				}
			}
			while (stopwatch.ElapsedMilliseconds < RUN_TIME);
		}
    }
}