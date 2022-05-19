using System;
using System.Linq;

class URI {
    static void Main(string[] args){
        double[] entrada;
        double x1;
        double y1;
        double x2;
        double y2;
        double distancia;

        entrada = Console.ReadLine().Split().Select(input => double.Parse(input)).ToArray();
        x1 = entrada[0];
        y1 = entrada[1];

        entrada = Console.ReadLine().Split().Select(input => double.Parse(input)).ToArray();
        x2 = entrada[0];
        y2 = entrada[1];

        distancia = DistanciaEntreDoisPontos(x1, y1, x2, y2);

        Console.WriteLine(String.Format("{0:0.0000}", distancia));
    }

    static double DistanciaEntreDoisPontos(double x1, double y1, double x2, double y2){
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}