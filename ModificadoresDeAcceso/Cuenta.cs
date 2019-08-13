using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Cuenta
    {

        public Cliente Propietario { get; set; }
        public string _identificador { get; set;}
        public string identificador { get; set;}
        public float saldo { get; set; }

        public void retirar ()
        {

        }

        public void Depositar()
        {

        }
    }
}
