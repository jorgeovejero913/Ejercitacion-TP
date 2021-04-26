using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Empresa
    {
        private string _razonSocial;

        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        private string _cuil;

        public string CUIL
        {
            get { return _cuil; }
            set { _cuil = value; }
        }

        private List<Cargo> _cargos= new List<Cargo>();

        protected List<Cargo> Cargos
        {
            get { return _cargos; }
            set { _cargos = value; }
        }

        public List<Cargo> CargosDisponibles()
        {
            Asistente objAsistente = new Asistente();
            Gerente objGerente = new Gerente();
            DirectorEjecutivo objDirectorEjecutivo = new DirectorEjecutivo();
            EjecutivoCuenta objEjecutivoCuenta = new EjecutivoCuenta();
            Operador objOperador = new Operador();

            this.Cargos.Add(objAsistente);
            this.Cargos.Add(objGerente);
            this.Cargos.Add(objDirectorEjecutivo);
            this.Cargos.Add(objEjecutivoCuenta);
            this.Cargos.Add(objOperador);

            return this.Cargos;
        }



        private List<Empleado> _empleados = new List<Empleado>();

        public List<Empleado> Empleados
        {
            get { return _empleados; }
            set { _empleados = value; }
        }

        public string CalcularSueldo(Empleado pEmpleado)
        {
            float sueldoFinal;
            string liquidacion;

            sueldoFinal = pEmpleado.Cargo.SueldoBasico();

            liquidacion = "El sueldo neto del empleado es= " + pEmpleado.Cargo.SueldoBasico();

            liquidacion += "\r\nEl bono por Antiguedad es de: $" + pEmpleado.BonoPorAntiguedad.DevolverBonoPorAntiguedad(pEmpleado.AniosAntiguedad, pEmpleado.Cargo).ToString();
            sueldoFinal += pEmpleado.BonoPorAntiguedad.DevolverBonoPorAntiguedad(pEmpleado.AniosAntiguedad, pEmpleado.Cargo);
 

            sueldoFinal += pEmpleado.AsignacionFamiliar.DevolverAsignacionFamiliar(pEmpleado.CantidadHijos);
            liquidacion += "\r\nLa asignacion familiar($100 por hijo) para el empleado por la cantidad de " + pEmpleado.CantidadHijos.ToString()+" HIJOS es de: $" + pEmpleado.AsignacionFamiliar.DevolverAsignacionFamiliar(pEmpleado.CantidadHijos);

            liquidacion += "\r\nEl sueldo final es de $" + sueldoFinal.ToString();

            return liquidacion;
        }
    }
}