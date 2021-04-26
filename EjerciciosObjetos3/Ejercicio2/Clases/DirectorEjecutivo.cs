using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class DirectorEjecutivo : Cargo
    {
        public override float SueldoBasico()
        {
            return 9000;
        }

        public DirectorEjecutivo()
        {
            this.Nombre = "Director Ejecutivo";
        }
    }
}
