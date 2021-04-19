using Clases;
using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Pepe");
            SueldoNeto sueldoNeto = new SueldoNeto();
            BonoPresentismo bonoPresentismo = new BonoPresentismo();
            BonoResultados bonoResultados = new BonoResultados();

            Console.WriteLine("Este programa determina cuanto gana {0}!", empleado.Nombre);

            //Ponemos algunas opciones para Pepe
            sueldoNeto.setNeto(1);
            bonoPresentismo.setAusenciasBono(0);
            bonoResultados.setBono(1, sueldoNeto.getNeto());
            empleado.setSueldo(sueldoNeto.getNeto(), bonoPresentismo.getBono(), bonoResultados.getBono());
            Console.WriteLine("Si pepe es Gerente, no falto ningun dia y tiene un 10% de bono, el ganaría: {0}", empleado.getSueldo().ToString());

            sueldoNeto.setNeto(1);
            bonoPresentismo.setAusenciasBono(1);
            bonoResultados.setBono(1, sueldoNeto.getNeto());
            empleado.setSueldo(sueldoNeto.getNeto(), bonoPresentismo.getBono(), bonoResultados.getBono());
            Console.WriteLine("Si pepe es Gerente, FALTO un dia y tiene un 10% de bono, el ganaría: {0}", empleado.getSueldo().ToString());

            sueldoNeto.setNeto(1);
            bonoPresentismo.setAusenciasBono(6);
            bonoResultados.setBono(1, sueldoNeto.getNeto());
            empleado.setSueldo(sueldoNeto.getNeto(), bonoPresentismo.getBono(), bonoResultados.getBono());
            Console.WriteLine("Si pepe es Gerente, FALTO mas de un dia y tiene un 10% de bono, el ganaría: {0}", empleado.getSueldo().ToString());

            sueldoNeto.setNeto(1);
            bonoPresentismo.setAusenciasBono(0);
            bonoResultados.setBono(2, sueldoNeto.getNeto());
            empleado.setSueldo(sueldoNeto.getNeto(), bonoPresentismo.getBono(), bonoResultados.getBono());
            Console.WriteLine("Si pepe es Gerente, no falto ningun dia y tiene un $80 de bono, el ganaría: {0}", empleado.getSueldo().ToString());

            sueldoNeto.setNeto(1);
            bonoPresentismo.setAusenciasBono(0);
            bonoResultados.setBono(3, sueldoNeto.getNeto());
            empleado.setSueldo(sueldoNeto.getNeto(), bonoPresentismo.getBono(), bonoResultados.getBono());
            Console.WriteLine("Si pepe es Gerente, no falto ningun dia y no tiene bono, el ganaría: {0}", empleado.getSueldo().ToString());

            sueldoNeto.setNeto(2);
            bonoPresentismo.setAusenciasBono(0);
            bonoResultados.setBono(1, sueldoNeto.getNeto());
            empleado.setSueldo(sueldoNeto.getNeto(), bonoPresentismo.getBono(), bonoResultados.getBono());
            Console.WriteLine("Si pepe es CADETE, no falto ningun dia y tiene un 10% de bono, el ganaría: {0}", empleado.getSueldo().ToString());

            sueldoNeto.setNeto(2);
            bonoPresentismo.setAusenciasBono(0);
            bonoResultados.setBono(2, sueldoNeto.getNeto());
            empleado.setSueldo(sueldoNeto.getNeto(), bonoPresentismo.getBono(), bonoResultados.getBono());
            Console.WriteLine("Si pepe es CADETE, no falto ningun dia y tiene un $80 de bono, el ganaría: {0}", empleado.getSueldo().ToString());

            sueldoNeto.setNeto(2);
            bonoPresentismo.setAusenciasBono(0);
            bonoResultados.setBono(3, sueldoNeto.getNeto());
            empleado.setSueldo(sueldoNeto.getNeto(), bonoPresentismo.getBono(), bonoResultados.getBono());
            Console.WriteLine("Si pepe es CADETE, no falto ningun dia y no tiene bono, el ganaría: {0}", empleado.getSueldo().ToString());

            Console.ReadKey();
        }
    }
}
