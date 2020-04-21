using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine_Simulator.engine
{
    struct EngineSpecs
    {
        public int num_of_cylinders;
        public double efficiency;
        public double bore;
        public double stroke;
        public double piston_connecting_rod_length;
        public double inertia;
    }

    class Engine
    {
        public Cylinder[] cylinders;
        public Crankshaft crankshaft;

        public double throttle_body_position = 0;

        private EngineSpecs es; 

        private int num_of_cylinders;
        private double efficiency;

        private double mass_of_air_avaliable;

        public Engine(EngineSpecs es)
        {
            this.es = es;

            cylinders = new Cylinder[es.num_of_cylinders];

            crankshaft = new Crankshaft(this, es);

            num_of_cylinders = es.num_of_cylinders;
            efficiency = es.efficiency;

            for(int i = 0; i < es.num_of_cylinders; i++)
            {
                double initial_piston_angle = 0;
                StrokeCycle initial_stroke = StrokeCycle.Intake;


                switch (i)
                {
                    case 0:
                        {
                            initial_piston_angle = 0;
                            initial_stroke = StrokeCycle.Intake;
                            break;
                        }
                    case 1:
                        {
                            initial_piston_angle = 180;
                            initial_stroke = StrokeCycle.Compression;
                            break;
                        }

                    case 2:
                        {
                            initial_piston_angle = 180;
                            initial_stroke = StrokeCycle.Exhaust;
                            break;
                        }

                    case 3:
                        {
                            initial_piston_angle = 0;
                            initial_stroke = StrokeCycle.Combustion;
                            break;
                        }
                }

                cylinders[i] = new Cylinder(es, crankshaft, initial_piston_angle, initial_stroke);
            }
        }

        public void Update(double delta)
        {
            foreach (Cylinder cylinder in cylinders)
            {
                //Add air on intake stage
                if(cylinder.current_stroke == StrokeCycle.Intake)
                {
                    //cylinder.mass_of_air += mass_of_air_avaliable / intake_cylinders.Count;

                    double air_kpa = 101.325;
                    double vol_of_cylinder = Math.Pow(es.bore / 2.0, 2) * Math.PI * es.stroke;

                    vol_of_cylinder *= throttle_body_position;

                    double air_temp = Constants.CELCIUS_TO_KELVIN * 25;

                    cylinder.mass_of_air = Air.Mass(air_kpa, vol_of_cylinder, air_temp);
                }

                cylinder.Update(delta);
            }

            crankshaft.Update(delta);

            mass_of_air_avaliable = 0;

            //Console.WriteLine(crankshaft.rpm);
        }

        public void InsertAir(double mass)
        {
            this.mass_of_air_avaliable += mass;
        }


    }
}
