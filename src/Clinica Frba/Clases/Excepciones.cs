using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Clases
{
    public class NoTrajoNadaExcep : Exception
    {
        public NoTrajoNadaExcep() {
        }
        public NoTrajoNadaExcep(string Mensaje)
            : base(Mensaje){
        }

    }
}
