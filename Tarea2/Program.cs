using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool salir = false;

            Proyectil flecha = new Proyectil("flecha", 10);
            Proyectil bala = new Proyectil("pistola", 20);

            List<Arma> armas = new List<Arma>();

            armas.Add(new ArmaMelee("Espadas del Caos", 10, 1, 15));
            armas.Add(new ArmaDistancia("Arco de Apolo", 5, 1.5f, 10, flecha));
            armas.Add(new ArmaDistancia("Revolver de Samuel Colt", 15, 0.5f, 20, bala));

            List<Arma> armasCompradas = new List<Arma>();

            while (!salir)
            {
                Console.WriteLine("Tienda:");
                for (int i = 0; i < armas.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + armas[i].ObtenerData());
                }
                Console.WriteLine("\n");
                Console.WriteLine("Ingrese el número de arma a comprar");
                string selection = Console.ReadLine();
                Console.WriteLine("\n");

                switch (selection)
                {
                    case "1":
                        armasCompradas.Add(armas[0]);
                        Console.WriteLine(armas[0].ObtenerNombre() + " agregado al inventario");
                        break;
                    case "2":
                        armasCompradas.Add(armas[1]);
                        Console.WriteLine(armas[1].ObtenerNombre() + " agregado al inventario");
                        break;
                    case "3":
                        armasCompradas.Add(armas[2]);
                        Console.WriteLine(armas[2].ObtenerNombre() + " agregado al inventario");
                        break;
                }
                Console.WriteLine("\n");
                bool bucle = false;

                while (!bucle)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------");
                    Console.WriteLine("¿Qué quieres hacer? \n");
                    Console.WriteLine("1. Comprar otra arma");
                    Console.WriteLine("2. Ver inventario");
                    Console.WriteLine("3. Eliminar arma");
                    Console.WriteLine("4. Salir \n");

                    string acción = Console.ReadLine();

                    switch (acción)
                    {
                        case "1":
                            bucle = true;
                            Console.WriteLine("\n");
                            break;
                        case "2":
                            Console.WriteLine("Inventario:");
                            for (int i = 0; i < armasCompradas.Count; i++)
                            {
                                Console.WriteLine((i + 1) + "." + armasCompradas[i].ObtenerData());
                            }
                            Console.WriteLine("\n");
                            break;
                        case "3":
                            Console.WriteLine("Inventario:");
                            for (int i = 0; i < armasCompradas.Count; i++)
                            {
                                Console.WriteLine((i + 1) + "." + armasCompradas[i].ObtenerData());
                            }
                            Console.WriteLine("\n");
                            Console.WriteLine("numero de arma a eliminar: ");
                            int eliminar = Int32.Parse(Console.ReadLine());
                            Console.WriteLine(armasCompradas[eliminar - 1].ObtenerNombre() + " eliminado");
                            armasCompradas.RemoveAt(eliminar - 1);
                            Console.WriteLine("\n");
                            break;
                        case "4":
                            bucle = true;
                            salir = true;
                            break;
                        default:
                            break;
                    }
                }
            }

        }
    }
}
