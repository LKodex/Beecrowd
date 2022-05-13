using System;

class URI {
    static void Main(string[] args){
        int segundos;
        int minutos;
        int horas;

        segundos = int.Parse(Console.ReadLine());
        horas = segundos / 60 / 60;
        minutos = segundos / 60 % 60;
        segundos = segundos % 60;

        Console.WriteLine(String.Format("{0}:{1}:{2}", horas, minutos, segundos));
    }
}