using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos_Abstracion
{
    class Cuadrado:Geometricos //Heredamos la clase geometricos
    {
        public override string Nombre { get; set; } //Para llamar a la abstracion tenemos que usar Override en cada metodo que vayamos a utilizar

        public override void Saludo()
        {
            Console.WriteLine("---CUADRADO---");

        }
        
        public override void Operacion(int Base = 5, int Altura = 3) 
        {

            double A = Base * Base;

            Console.WriteLine("AREA: " + A);
            double P = Base + Base + Base + Base;
            Console.WriteLine("PERIMETRO: " + P);
        }

    }
}
