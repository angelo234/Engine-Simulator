using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine_Simulator.engine
{
    enum StrokeCycle
    {
        Intake,
        Compression,
        Combustion,
        Exhaust
    }

    class Cylinder
    {
        public StrokeCycle current_stroke;

        public Piston piston;

        public double mass_of_air;

        private EngineSpecs es;
        

        //Diameter of cylinder
        private double bore;
        private double stroke;
  
        private double mass_of_gasoline;


        public Cylinder(EngineSpecs es, Crankshaft crankshaft, double initial_crank_angle, StrokeCycle initial_stroke)
        {
            this.es = es;
            piston = new Piston(es, crankshaft, initial_crank_angle);
            bore = es.bore;
            stroke = es.stroke;
            this.current_stroke = initial_stroke;
        }

        public void Update(double delta)
        {
            UpdateCurrentStroke();

            if(current_stroke == StrokeCycle.Combustion)
            {
                piston.force_on_piston = Gasoline.CombustionEnergyReleasedJoules(mass_of_air / 14.7, mass_of_air) 
                    / es.stroke * es.efficiency;
            }

            piston.Update(delta);
        }

        private void UpdateCurrentStroke()
        {
            if(piston.angle_of_current_stroke >= 180)
            {
                //Either now in intake or power stroke

                if(current_stroke == StrokeCycle.Intake)
                {
                    current_stroke = StrokeCycle.Compression;
                }
                else if(current_stroke == StrokeCycle.Compression)
                {
                    current_stroke = StrokeCycle.Combustion;
                }
                else if(current_stroke == StrokeCycle.Combustion)
                {
                    current_stroke = StrokeCycle.Exhaust;
                }
                else if(current_stroke == StrokeCycle.Exhaust)
                {
                    current_stroke = StrokeCycle.Intake;
                }

                piston.angle_of_current_stroke -= 180.0;
            } 
        }
    }
}
