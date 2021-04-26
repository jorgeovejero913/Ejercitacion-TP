using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Empleado
    {
        private string _nombre;
        private string _apellido;
        private string _cuil;
        private int _cantidadHijos;
        private int _aniosAntiguedad;
        private Cargo cargo;
        private AsignacionFamiliar asignacionFamiliar;
        private BonoPorAntiguedad bonoPorAntiguedad;

        public Empleado()
        {
            this.BonoPorAntiguedad = new BonoPorAntiguedad();
            this.AsignacionFamiliar = new AsignacionFamiliar();
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Cuil
        {
            get { return _cuil; }
            set { _cuil = value; }
        }

        public int CantidadHijos
        {
            get { return _cantidadHijos; }
            set { _cantidadHijos = value; }
        }

        public int AniosAntiguedad
        {
            get { return _aniosAntiguedad; }
            set { _aniosAntiguedad = value; }
        }

        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public AsignacionFamiliar AsignacionFamiliar
        {
            get { return asignacionFamiliar; }
            set { asignacionFamiliar = value; }
        }

        public BonoPorAntiguedad BonoPorAntiguedad
        {
            get { return bonoPorAntiguedad; }
            set { bonoPorAntiguedad = value; }
        }
    }
}
