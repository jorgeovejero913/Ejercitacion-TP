using System;

namespace Clases
{
    public abstract class Cargo
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public abstract float SueldoBasico();
    }
}
