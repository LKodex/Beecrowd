using System; 

class URI {
    static void Main(string[] args) { 
        int a;
        int b;
        
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("X = {0}", a + b));
    }
}