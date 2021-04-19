using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class BonoResultados
    {

        private double _bono;
        private const int DIEZ_PORCIENTO = 1;
        private const int OCHENTA_FIJOS = 2;
        public double getBono()
        {
            return this._bono;
        }
        public void setBono(int tipoBono, double neto)
        {
            switch (tipoBono)
            {
                case DIEZ_PORCIENTO:
                    this._bono = neto*0.1;
                    break;
                case OCHENTA_FIJOS:
                    this._bono = 80;
                    break;
                default:
                    this._bono = 0;
                    break;
            }
        }
    }
}
