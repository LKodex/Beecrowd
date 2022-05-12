using System; 

class URI {
    const double PESO_A = 2;
    const double PESO_B = 3;
    const double PESO_C = 5;
    const double PESO_TOTAL = PESO_A + PESO_B + PESO_C;
    
    static void Main(string[] args) { 
        double notaA;
        double notaB;
        double notaC;
        double media;

        notaA = double.Parse(Console.ReadLine());
        notaB = double.Parse(Console.ReadLine());
        notaC = double.Parse(Console.ReadLine());
        
        media = (notaA * PESO_A + notaB * PESO_B + notaC * PESO_C) / PESO_TOTAL;

        Console.WriteLine(String.Format("MEDIA = {0:0.0}", media));
    }
}