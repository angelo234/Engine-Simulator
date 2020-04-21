using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine_Simulator
{
    static class Program
    {

        public static Physics physics;
        
        static void PhysicsLoop()
        {
            physics = new Physics();

            while (true)
            {
                Update();

                //1000 Updates per second
                Thread.Sleep(1);
            }
        }

        static void Update()
        {
            physics.Update(1.0/1000.0);
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
