using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro
{
    
    internal class LIbroP
    {
        private int isbn;
        private string nombreLibro;
        private string autor;
        private int ejemplares;
        private int prestamos;
        private int devolver;

        public int Isbn { get => isbn; set => isbn = value; }
        public string NombreLibro { get => nombreLibro; set => nombreLibro = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Ejemplares { get => ejemplares; set => ejemplares = value; }
        public int Prestamos { get => prestamos; set => prestamos = value; }
        public int Devolver { get => devolver; set => devolver = value; }

        public LIbroP()
        {
        }
        public LIbroP(int isbn, string nombreLibro, string autor, int ejemplares)
        {
            this.Isbn = isbn;
            this.NombreLibro = nombreLibro;
            this.Autor = autor;
            this.Ejemplares = ejemplares;
            
        }
        int con_prestamos = 0, con_devoliciones = 0;
        int librosprestados, librosdevuletos;
        string nombreresponsable;
        int opcion, respuesta;

        public void Menu()
        {
            

            Console.Write("\n\n\t\tDesea Ingresar Al Menu De Inicio (1= NO & 2 = SI): ");
            respuesta = int.Parse(Console.ReadLine());

            while (respuesta != 2)
            {
                Console.WriteLine("\n\n\t\tMenu de Inico ");
                Console.WriteLine(" 1. Crear Registo ");
                Console.WriteLine(" 2. Prestar Libro ");
                Console.WriteLine(" 3. Devolver Libro ");
                Console.WriteLine(" 4. Consultar Libro ");

                Console.Write(" Ingrese el digito de la opcion a la cual desea ingresar: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            CrearLibro();
                            break;
                        }
                    case 2:
                        {
                            PrestarLibro();
                            break;
                        }
                    case 3:
                        {
                            DevolverLibro();
                            break;
                        }
                    case 4:
                        {
                            ConsultarLibro();
                            break;
                        }

                    default:
                        {
                            Console.Write("opcion no valida");
                            break;
                        }

                }
                Console.Write("\n\n\t\tDesea Saril (1= NO & 2 = SI): ");
                respuesta = int.Parse(Console.ReadLine());

            }

        }

        public void CrearLibro()
        {
            Console.Write("\n\n\n\t\tCrear Libro");

            Console.Write("\n\nIngrese el ISBN del libro: ");
            isbn = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del libro: ");
            nombreLibro  = Console.ReadLine();

            Console.Write("Ingrese el nombre del autor del libro: ");
            autor = Console.ReadLine();

            Console.Write("Ingrese el la cantidad de ejemplares: ");
            ejemplares = int.Parse(Console.ReadLine());


        }

        public int PrestarLibro()
        {
            

            Console.Write("\n\n\n\t\tPrestar Libro");

            Console.Write("\n\nIngrese el nombre del responsable: ");
            nombreresponsable = Console.ReadLine();

            Console.Write("Ingrese el nombre del libro: ");
            nombreLibro = Console.ReadLine();

            if (ejemplares != 0)
            {
                Console.Write("Ingrese la cantidad de libros a prestar: ");
                prestamos = int.Parse(Console.ReadLine());
                con_prestamos = con_prestamos + prestamos;

                librosprestados = ejemplares - prestamos;

                Console.WriteLine("la cantidad de libros prestados es: " + con_prestamos);
                Console.WriteLine("la cantidad de ejemplares es: " + librosprestados);
                
            }

            else 
            {
                Console.Write("No se puede prestar este libro ya que no se cuenta con ejemplareres ");
            }
            

            return librosprestados;

        }

        public int DevolverLibro()
        {

            Console.Write("\n\n\n\t\tDevolver Libro");

            Console.Write("\n\nIngrese el nombre del responsable: ");
            nombreresponsable = Console.ReadLine();

            Console.Write("Ingrese el nombre del libro: ");
            nombreLibro = Console.ReadLine();

            Console.Write("Ingrese la cantidad de libros a devolver: ");
            devolver = int.Parse(Console.ReadLine());
            con_devoliciones = con_devoliciones + devolver;

            librosdevuletos = ejemplares - (prestamos-devolver);

            Console.WriteLine("la cantidad de libros prestados es: " + con_devoliciones);
            Console.WriteLine("la cantidad de ejemplares es: " + librosdevuletos);

            return librosdevuletos;
        }

        public void ConsultarLibro()
        {

            Console.Write("\n\n\n\t\tConsultar Libro");

            Console.Write("\n\nIngrese el numero ISBN: ");
            isbn = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre del libro: " + nombreLibro);
            Console.WriteLine("Autor del libro: " + autor);
            Console.WriteLine("Ejemplares: " + ejemplares);
            Console.WriteLine("Prestamos: " + prestamos);
            Console.WriteLine("Devolucines: " + devolver);

        }

        public void Imprimir()
        {
            if (opcion ==2)
            {
                Console.Write("\n\n\n\t\tRecibo Prestamo");
                Console.WriteLine("\n\nNombre del responsable: " + nombreresponsable);
                Console.WriteLine("Libro Prestado: " + nombreLibro);
                Console.WriteLine("Cantidad de libros Prestados: " + prestamos);
            }

            else if (opcion == 3 )
            {
                Console.Write("\n\n\n\t\tRecibo Devolucion");
                Console.WriteLine("\n\nNombre del responsable: " + nombreresponsable);
                Console.WriteLine("Libro Prestado: " + nombreLibro);
                Console.WriteLine("Cantidad de libros Devuelto: " + devolver);
            }
        }
    }
}
