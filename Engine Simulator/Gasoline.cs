using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine_Simulator
{
    static class Gasoline
    {
        // kJ/g
        public const double ENERGY_DENSITY = 45f;

        // g/cm^3
        public const double DENSITY = 0.7489f;

        public static double CombustionEnergyReleasedJoules(double gas_mass, double air_mass)
        {
            double afr = 14.7;

            //Convert from kg to g
            air_mass *= 1000;
            gas_mass *= 1000;

            double gas_mass_used = Math.Min(air_mass / afr, gas_mass);

            return ENERGY_DENSITY * gas_mass_used * 1000;
        }
    }
}
