using System.Security.Cryptography.X509Certificates;

namespace espacioCalculadora
{
    public class Calculadora
    {
        private double resultado = 0;
        public double RESULTADO
        {
            get;
        }
        public void Sumar(double termino)
        {
            resultado += termino;
        }
        public void Restar(double termino)
        {
            resultado -= termino;
        }
        public void Multiplicar(double termino)
        {
            resultado *= termino;
        }
        public void Dividir(double termino)
        {
            resultado /= 0;
        }
        public void Limpiar()
        {
            resultado = 0;
        }
    }
}