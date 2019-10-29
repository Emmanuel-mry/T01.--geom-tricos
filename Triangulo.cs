using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos_Abstracion
{
    class Triangulo:Geometricos //Heredamos la clase geometricos
    {
        public override string Nombre { get; set; } //Para llamar a la abstracion tenemos que usar Override en cada metodo que vayamos a utilizar

        public override void Saludo()
        {
            Console.WriteLine("---TRIANGULO---");

        }

        public override void Operacion(int Base = 5, int Altura = 3)
        {//En todas las clases de figuras utilizaremos los metodos de abstracion lo unico que cambia es las operaciones

            double A = (Base * Altura) / 2;
            Console.WriteLine("AREA: " + A);
           
        }
    }
}
