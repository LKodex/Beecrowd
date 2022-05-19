using System;

class URI {
    static void Main(string[] args){
        int kmRodado;
        double combustivelGasto;
        double consumo;

        kmRodado = int.Parse(Console.ReadLine());
        combustivelGasto = double.Parse(Console.ReadLine());

        consumo = kmRodado / combustivelGasto;

        Console.WriteLine(String.Format("{0:0.000} km/l", consumo));
    }
}