using System; 

class URI {
    const double PI = 3.14159;

    static void Main(string[] args) { 
        double raio;
        double area;

        raio = double.Parse(Console.ReadLine());

        area = raio * raio * PI;

        Console.WriteLine(String.Format("A={0:0.0000}", area));
    }
}