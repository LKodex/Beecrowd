using System; 
using System.Linq;

class URI {
    const double PI = 3.14159;

    static void Main(string[] args) { 
        double[] entrada;
        double areaTrianguloRetangulo;
        double areaDoCirculoPeloRaio;
        double areaTrapezio;
        double areaQuadrado;
        double areaRetangulo;

        // Entrada
        entrada = Console.ReadLine().Split().Select(input => double.Parse(input)).ToArray();

        // Processamento
        areaTrianguloRetangulo = AreaTrianguloRetangulo(entrada[0], entrada[2]);
        areaDoCirculoPeloRaio = AreaDoCirculoPeloRaio(entrada[2]);
        areaTrapezio = AreaTrapezio(entrada[0], entrada[1], entrada[2]);
        areaQuadrado = AreaQuadrado(entrada[1]);
        areaRetangulo = AreaRetangulo(entrada[0], entrada[1]);

        // Saída
        Console.WriteLine("TRIANGULO: {0:0.000}", areaTrianguloRetangulo);
        Console.WriteLine("CIRCULO: {0:0.000}", areaDoCirculoPeloRaio);
        Console.WriteLine("TRAPEZIO: {0:0.000}", areaTrapezio);
        Console.WriteLine("QUADRADO: {0:0.000}", areaQuadrado);
        Console.WriteLine("RETANGULO: {0:0.000}", areaRetangulo);
    }

    static double AreaTrianguloRetangulo(double baseTR, double alturaTR){
        return baseTR * alturaTR / 2.0;
    }

    static double AreaDoCirculoPeloRaio(double raio){
        return Math.Pow(raio, 2) * PI;
    }

    static double AreaTrapezio(double baseA, double bsaeB, double altura){
        return (baseA + bsaeB) * altura / 2.0;
    }

    static double AreaQuadrado(double lado){
        return lado * lado;
    }

    static double AreaRetangulo(double baseR, double alturaR){
        return baseR * alturaR;
    }
}
