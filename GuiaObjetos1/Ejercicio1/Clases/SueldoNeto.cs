using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class SueldoNeto
    {
        private int _categoria;
        private double _neto;
        private const int GERENTE = 1;
        private const int CADETE = 2;

        public SueldoNeto()
        {
        }

        public double getNeto()
        {
            return _neto;
        }

        public void setNeto(int categoria)
        {
            switch (categoria)
            {
                case GERENTE:
                    this._neto = 1000;
                    break;
                case CADETE:
                    this._neto = 1500;
                    break;
                default:
                    this._neto = 0;
                    break;
            }
        }
    }
}
