using System;
using System.Collections.Generic;

namespace Clases
{
    public class Calculador
    {
        private float _num = 0;
        private float _acumulado = 0;
        private string _historial = "";

        public float Num
        {
            get { return _num; }
            set { _num = value; }
        }

        public float Acumulado
        {
            get { return _acumulado; }
            set { _acumulado = value; }
        }

        public string Historial
        {
            get { return _historial; }
            set { _historial = value; }
        }

        public void sumar()
        {
            Historial += Acumulado+" + "+Num+" = "+(Acumulado + Num).ToString() + "\r\n";

            Acumulado += Num;
        }

        public void restar()
        {
            Historial += Acumulado + " - " + Num + " = " + (Acumulado - Num).ToString() + "\r\n";

            Acumulado -= Num;
        }


    }
}
