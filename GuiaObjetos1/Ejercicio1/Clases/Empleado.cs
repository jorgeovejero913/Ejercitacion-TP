using System;

namespace Clases
{
    public class Empleado
    {
        private string _nombre;
        private double _sueldo;

        public Empleado(string nombre)
        {
            this._nombre = nombre;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public double getSueldo()
        {
            return this._sueldo;
        }

        public void setSueldo(double neto, double presentismo, double resultado)
        {
            this._sueldo = neto + presentismo + resultado;
        }
    }
}
