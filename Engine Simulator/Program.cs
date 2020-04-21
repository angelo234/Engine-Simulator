using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine_Simulator
{
    static class Program
    {

        public static Physics physics;

        private static long last_time;
        private static long last_update_time;

        private static double delta = 0;

        private static long NanoTime()
        {
            long nano = 10000L * Stopwatch.GetTimestamp();
            nano /= TimeSpan.TicksPerMillisecond;
            nano *= 100L;
            return nano;
        }

        static void PhysicsLoop()
        {
            physics = new Physics();

            last_time = NanoTime();

            while (true)
            {
                long time_now = NanoTime();

                double updates_per_second = 1000.0;

                double time = (time_now - last_time) / (1_000_000_000.0 / updates_per_second);

                delta += time;
                last_time = time_now;

                while (delta >= 1)
                {
                    delta--;

                    Update();
                }
            }
        }
        static double GetDeltaTime()
        {
            long time_now = NanoTime();

            double delta = (time_now - last_update_time) / 1_000_000_000.0;

            last_update_time = time_now;

            return delta;
        }

        static void Update()
        {
            double delta = GetDeltaTime();

            physics.Update(1/1000.0);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread physics_thread = new Thread(PhysicsLoop);

            physics_thread.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
