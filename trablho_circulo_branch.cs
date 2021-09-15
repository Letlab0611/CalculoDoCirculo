using System;
using System.Globalization;

namespace liçãoDaniel
{
    class Program
    {
        //cria classe calculadora
        calculadora calc = new calculadora();
        //pede valor do raio, e calcula circunferencia e volume
        Console.WriteLine("Entre o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double circ = calc.Circuferencia(raio);
        double volume = calc.Volume(raio);
        //mostra resultados e valor de pi
        Console.WriteLine("Circuferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
    }
    class calculadora
    {
        //contas matemáticas
        public double Pi = 3.14;
        public double Circunferencia(double r) { return 2.0 * Pi * r; }
        public double Volume(double r) { return 4.0 / 3.0 * Pi * r * r * r; }
    }

}
