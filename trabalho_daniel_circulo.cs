using System;
using System.Globalization;

namespace liçãoDanielMain
{

    class Program
    {
        //declara valor de pi
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            //pede pelo valor do raio e calcula.
            Console.WriteLine("Entre com valor do raio: ");
            //envia valores pra outra função
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circuferencia(raio);
            double volume = Volume(raio);
            //mostra resultados
            Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double Circuferencia(double r)
        {
            //calcula circunferencia
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            //calcula volume
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }


}