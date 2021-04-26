using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class EjecutivoCuenta : Cargo
    {
        public override float SueldoBasico()
        {
            return 2000;
        }

        public EjecutivoCuenta()
        {
            this.Nombre = "Ejecutivo de Cuenta";
        }
    }
}
