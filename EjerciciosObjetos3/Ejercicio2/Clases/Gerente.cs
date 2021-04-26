using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Gerente : Cargo
    {
        public override float SueldoBasico()
        {
            return 5000;
        }

        public Gerente()
        {
            this.Nombre = "Gerente";
        }
    }
}
