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

        }
    }
}
