using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine_Simulator.engine
{
    class Crankshaft
    {
        public Engine engine;

        public double total_torque;

        public double last_hp;
        public double last_total_torque;

        public double rpm = 1000;

        public double crank_angle = 0;
        public double last_crank_angle;

        private double inertia;

        public Crankshaft(Engine engine, EngineSpecs es)
        {
            this.engine = engine;
            inertia = es.inertia;
        }

        public void Update(double delta)
        {
            //torque / inertia = acceleration

            double ang_accel = total_torque / inertia;

            rpm += ang_accel * delta * 9.5492965964254;

            crank_angle += rpm * 6 * delta;


            foreach(Cylinder cylinder in engine.cylinders)
            {
                //crank_angle += crankshaft.rpm * 6 * delta;
                //angle_of_current_stroke += crankshaft.rpm * 6 * delta;

                cylinder.piston.crank_angle += rpm * 6 * delta;
                cylinder.piston.angle_of_current_stroke += rpm * 6 * delta;
            }
            

            /*
            if (crank_angle >= 360)
            {
                crank_angle -= 360;
            }
            */

            double hp = (total_torque * rpm / 1.356) / 5252;

            last_hp = hp;

            last_total_torque = total_torque;
            last_crank_angle = crank_angle;

            total_torque = 0;


        }
    }
}
