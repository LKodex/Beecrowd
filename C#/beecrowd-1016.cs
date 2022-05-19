using System;

class URI {
    static void Main(string[] args){
        int distancia;

        distancia = int.Parse(Console.ReadLine()) * 2;

        Console.WriteLine(String.Format("{0} minutos", distancia));
    }
}