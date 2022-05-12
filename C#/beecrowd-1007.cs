using System; 

class URI {
    static void Main(string[] args) { 
        int a;
        int b;
        int c;
        int d;
        int diferenca;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());
        diferenca = a * b - c * d;

        Console.WriteLine(String.Format("DIFERENCA = {0}", diferenca));
    }
}