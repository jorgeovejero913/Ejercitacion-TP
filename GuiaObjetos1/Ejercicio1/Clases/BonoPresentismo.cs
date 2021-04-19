using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class BonoPresentismo
    {
        private int _ausencias;
        private double _bono;

        public double getBono()
        {
            return this._bono;
        }
        public void setAusenciasBono(int ausencias)
        {
            this._ausencias = ausencias;
            switch (ausencias)
            {
                case 0:
                    this._bono = 100;
                    break;
                case 1:
                    this._bono = 50;
                    break;
                default:
                    this._bono = 0;
                    break;
            }
        }
    }
}
