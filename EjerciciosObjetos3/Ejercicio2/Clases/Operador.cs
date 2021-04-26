using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Operador : Cargo
    {
        public override float SueldoBasico()
        {
            return 1500;
        }

        public Operador()
        {
            this.Nombre = "Operador";
        }
    }
}
