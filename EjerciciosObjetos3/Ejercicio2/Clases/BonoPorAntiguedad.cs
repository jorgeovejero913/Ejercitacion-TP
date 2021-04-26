using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class BonoPorAntiguedad
    {
        public float DevolverBonoPorAntiguedad(int anios, Cargo cargo)
        {

            float result = anios * (cargo.SueldoBasico() * (float)0.07);
            return result;
        }
    }
}
