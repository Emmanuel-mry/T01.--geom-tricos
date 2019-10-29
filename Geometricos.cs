using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos_Abstracion
{
   public abstract class Geometricos
    {
             
            public abstract void Operacion(int Base = 5, int Altura = 3);

            public abstract void Saludo();
            public abstract string Nombre { get; set; }
        
    }
}
