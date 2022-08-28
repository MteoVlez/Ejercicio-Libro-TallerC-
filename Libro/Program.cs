using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LIbroP LibroPrestamo1 = new LIbroP();
          
            LibroPrestamo1.Isbn = 456;
            LibroPrestamo1.NombreLibro = "Carruceles";
            LibroPrestamo1.Autor = "Margara";
            LibroPrestamo1.Ejemplares = 0;

            LibroPrestamo1.Menu();
            LibroPrestamo1.Imprimir();

            Console.ReadKey();
        }
    }
}
