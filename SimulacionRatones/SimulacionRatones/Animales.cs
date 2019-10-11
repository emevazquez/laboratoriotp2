using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionRatones
{
    abstract class Animales
    {
        bool vida;
        int posicion;
        int hambre;

        public Animales(int posicion)
        {
            this.posicion = posicion;
            vida = true;
            hambre = 2;
        }

        public abstract void Mover();
        public abstract void Comer();
        public abstract void VerificarComida();
        public abstract void VerificarMuerte();
    }
}
