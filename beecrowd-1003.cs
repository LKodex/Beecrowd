using System; 

class URI {
    static void Main(string[] args) { 
        int a;
        int b;
        int soma;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        
        soma = a + b;

        Console.WriteLine(String.Format("SOMA = {0}", soma));
    }
}