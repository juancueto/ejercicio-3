using System;
namespace ejercicio1
{
    public class Ejercicio1
    {
        public Ejercicio1()
        {
        }

        public int Sumar(int a, int b, int c)
        {
            return a + b + c;
        }

    }

    public class Coche
    {
        private int _NumeroPuertas;

        public int NumeroPuertas
        {
            get { return this._NumeroPuertas; }
        }
        public void AgregarPuertas(int puertas)
        {
            this._NumeroPuertas += puertas;
        }
    }
}

