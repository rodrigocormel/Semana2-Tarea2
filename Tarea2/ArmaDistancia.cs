using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class ArmaDistancia : Arma
    {
        private Proyectil proyectil;

        public ArmaDistancia(string nombre, float daño, float velocidadAtaque, int precio , Proyectil proyectil)
        {
            this.daño = daño;
            this.nombre = nombre;
            this.velocidadAtaque = velocidadAtaque;
            this.precio = precio;
            this.proyectil = proyectil;
        }

        public override float DañoPorSegundo()
        {
            return daño + proyectil.ObtenerDaño()/ velocidadAtaque;
        }

        public override string ObtenerData()
        {
            return $"{nombre} / daño: {daño} / velocidad de ataque: {velocidadAtaque} / precio: {precio} / usa proyectil: {proyectil.ObtenerNombre()} con daño {proyectil.ObtenerDaño()}";
        }
    }
}
