using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Proyectil
    {
        public float daño;
        public string nombre;

        public Proyectil(string nombre, float daño) 
        {
            this.nombre = nombre;
            this.daño = daño;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public float ObtenerDaño()
        {
            return daño;
        }
    }
}
