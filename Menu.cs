using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos_Abstracion
{
    class Menu
    {
       
           
            public void menu() //Creamos un metodo menu para que el usuario elija lo que desea realizar
            {
                //Instanciamos las clases para poder llamarlas
                Triangulo T = new Triangulo();
                Cuadrado C = new Cuadrado();
                Rectangulo R = new Rectangulo();

                //Este es el menu que se va mostrar
                Console.WriteLine("SELECCIONE LA OPCION QUE DESEA REALIZAR");
                Console.WriteLine();
                Console.WriteLine("1) TRIANGULO");
                Console.WriteLine("2) CUADRADO");
                Console.WriteLine("3) RECTANGULO");
                Console.WriteLine("4) TODAS LAS ANTERIORES");
                
             

                switch (Convert.ToInt32(Console.ReadLine()))
                {
               
                    case 1: //Muestra el area y perimetro del Triangulo
                    Console.Clear(); //Limpiamos la pantalla en cada caso para que se vea bien perron
                        T.Saludo();
                        T.Operacion();
                        Console.ReadKey();
                        Console.Clear();
                        menu();
                        break;
                    case 2:
                    Console.Clear();
                        C.Saludo();
                        C.Operacion();
                        Console.ReadKey();
                        Console.Clear();
                        menu();
                        break;
                    case 3:
                    Console.Clear();
                        R.Saludo();
                        R.Operacion();
                        Console.ReadKey();
                        Console.Clear();
                        menu();

                        break;
                    case 4:
                        T.Saludo();
                        T.Operacion();
                        C.Saludo();
                        C.Operacion();
                        R.Saludo();
                        R.Operacion();
                        Console.ReadKey();
                    break;
                default:
                    break;

                   


            }
            Console.Clear();
            menu();
       }
   }
}
