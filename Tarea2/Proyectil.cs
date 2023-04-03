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

        public Proyectil(float daño , string nombre) 
        {
            this.nombre = nombre;
            this.daño = daño;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public float Daño()
        {
            return daño;
        }
    }
}
