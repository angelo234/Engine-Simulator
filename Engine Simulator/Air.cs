using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine_Simulator
{
    static class Air
    {
        private const double SPECIFIC_GAS_CONSTANT = 287.058;

        public static double Mass(double kpa, double volume, double kelvin)
        {
            //return (kpa * 1000 * volume) / (SPECIFIC_GAS_CONSTANT * kelvin);

            return volume * 1.184;
        }
    }
}
