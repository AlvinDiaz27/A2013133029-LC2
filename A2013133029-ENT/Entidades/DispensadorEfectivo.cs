using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2013133029_ENT
{
    class DispensadorEfectivo
    {
        public int DispensadorEfectivoId { get; set; }
        private int _Contador = -500;
        public ATM ATM { get; set; }
        public Retiro Retiro { get; set; }

        public int Contador
        {
            get { return _Contador; }
        }

        public DispensadorEfectivo()
        {

        }
    }
}
