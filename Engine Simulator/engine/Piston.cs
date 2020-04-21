using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine_Simulator.engine
{
    class Piston
    {
        public double crank_angle;
        public double angle_of_current_stroke;
        public double force_on_piston;

        private EngineSpecs es;
        private Crankshaft crankshaft;   
        
        private double crank_radius;
        private double connecting_rod_length;

        public Piston(EngineSpecs es, Crankshaft crankshaft, double initial_crank_angle)
        {
            this.es = es;
            this.crankshaft = crankshaft;
            this.crank_angle = initial_crank_angle;
            this.angle_of_current_stroke = 0;
            crank_radius = es.stroke / 2f;
            connecting_rod_length = es.piston_connecting_rod_length;
        }

        public void Update(double delta)
        {
            crank_angle += crankshaft.rpm * 6 * delta;
            angle_of_current_stroke += crankshaft.rpm * 6 * delta;

            double crank_angle_rads = Math.PI / 180f * crank_angle;
            double crank_radius = es.stroke / 2f;

            double x = crank_radius / es.piston_connecting_rod_length * Math.Sin(crank_angle_rads);
            double a = Math.Asin(x);

            double crank_force = force_on_piston * Math.Cos(a) * Math.Sin(a + crank_angle_rads);

            //Console.WriteLine("Crank Force: "+crank_force);

            crankshaft.total_torque += crank_force * crank_radius;

            force_on_piston = 0;
        }
    }
}
