using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionRatones
{
    abstract class Animales
    {
        string nombre;
        bool vida;
        int posicion;
        int hambre;

        public Animales(int posicion, string nom)
        {
            this.nombre = nom;
            this.posicion = posicion;
            vida = true;
            hambre = 0;
        }

        public abstract void Mover();
        public abstract void Comer();
        public abstract void VerificarComida();
        public abstract void VerificarMuerte();
    }
}
