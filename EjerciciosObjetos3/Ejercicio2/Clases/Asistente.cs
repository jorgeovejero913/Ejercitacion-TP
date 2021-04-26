using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Asistente : Cargo
    {
        public override float SueldoBasico()
        {
            return 1000;
        }

        public Asistente(){
            this.Nombre = "Asistente";
        }
    }
}
