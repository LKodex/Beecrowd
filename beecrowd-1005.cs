using System; 

class URI {
    const double PESO_TOTAL = 11.0;
    const double PESO_A = 3.5;
    const double PESO_B = 7.5;
    
    static void Main(string[] args) { 
        double notaA;
        double notaB;
        double media;

        notaA = double.Parse(Console.ReadLine());
        notaB = double.Parse(Console.ReadLine());
        
        media = (notaA * PESO_A + notaB * PESO_B) / PESO_TOTAL;

        Console.WriteLine(String.Format("MEDIA = {0:0.00000}", media));
    }
}