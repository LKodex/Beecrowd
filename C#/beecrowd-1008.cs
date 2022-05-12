using System; 

class URI {
    static void Main(string[] args) { 
        int number;
        int workedHours;
        double salaryPerHour;
        double totalPayment;

        number = int.Parse(Console.ReadLine());
        workedHours = int.Parse(Console.ReadLine());
        salaryPerHour = double.Parse(Console.ReadLine());
        
        totalPayment = workedHours * salaryPerHour;

        Console.WriteLine(String.Format("NUMBER = {0}\nSALARY = U$ {1:0.00}", number, totalPayment));
    }
}