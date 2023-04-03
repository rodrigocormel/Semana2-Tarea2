using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    abstract class Arma
    {
        protected string nombre;
        protected float daño;
        protected float velocidadAtaque;
        protected int precio;

        public abstract float DañoPorSegundo();

        public string ObtenerNombre()
        {
            return nombre;
        }

        public virtual string ObtenerData()
        {
            return $"{nombre} / daño: {daño} / velocidad de ataque: {velocidadAtaque} / precio: {precio}";
        }
    }
}
