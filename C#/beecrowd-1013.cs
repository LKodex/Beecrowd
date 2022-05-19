using System;
using System.Linq;

class URI {
    static void Main(string[] args) {
        int[] valoresEntrada;
        int maior;

        valoresEntrada = Console.ReadLine().Split().Select(input => int.Parse(input)).ToArray();

        maior = maiorAB(valoresEntrada[0], valoresEntrada[1]);
        maior = maiorAB(maior, valoresEntrada[2]);

        Console.WriteLine(String.Format("{0} eh o maior", maior));
    }
    
    static int maiorAB(int a, int b){
           return (a + b + Math.Abs(a - b)) / 2;
    }
}