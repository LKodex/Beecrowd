using System; 

class URI {
    static void Main(string[] args) { 
        int a;
        int b;
        int prod;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        
        prod = a * b;

        Console.WriteLine(String.Format("PROD = {0}", prod));
    }
}