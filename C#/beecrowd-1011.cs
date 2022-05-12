using System;
using System.Collections.Generic;

class URI {
    const double PI = 3.14159;
    const double CONVERSAO_VOLUME_DA_ESFERA = 4.0 / 3.0;

    static void Main(string[] args) { 
        double raio;
        double volume;

        raio = double.Parse(Console.ReadLine());

        volume = CONVERSAO_VOLUME_DA_ESFERA * PI * Math.Pow(raio, 3); 

        Console.WriteLine(String.Format("VOLUME = {0:0.000}", volume));
    }
}