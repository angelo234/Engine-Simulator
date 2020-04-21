using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine_Simulator
{
    class Physics
    {
        public engine.Engine engine;

        public Physics()
        {
            engine.EngineSpecs es = new engine.EngineSpecs
            {
                //diameter of cylinder
                bore = 0.086f,

                //height of cylinder
                stroke = 0.086f,

                num_of_cylinders = 4,
                piston_connecting_rod_length = 0.139f,
                //inertia = 10f * 0.08f * 0.08f,
                inertia = 1000f * 0.08f * 0.08f,

                efficiency = 0.33f
            };

            engine = new engine.Engine(es);
        }

        public void Update(double delta)
        {
            engine.Update(delta);
        }
    }
}
