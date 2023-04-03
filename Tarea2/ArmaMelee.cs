using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class ArmaMelee : Arma
    {
        public ArmaMelee(string nombre, float daño, float velocidadAtaque,int precio)
        {
            this.nombre = nombre;
            this.daño = daño;
            this.velocidadAtaque = velocidadAtaque;
            this.precio = precio;
        }

        public override float DañoPorSegundo()
        {
            return daño / velocidadAtaque;
        }
    }
}
