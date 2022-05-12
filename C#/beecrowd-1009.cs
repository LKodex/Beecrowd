using System; 

class URI {
    const double SELLING_COMMISSION = 0.15;

    static void Main(string[] args) { 
        string sellerName;
        double sellerSallary;
        double sellerTotalSells;
        double sellerTotalPayment;

        sellerName = Console.ReadLine();
        sellerSallary = double.Parse(Console.ReadLine());
        sellerTotalSells = double.Parse(Console.ReadLine());
        
        sellerTotalPayment = sellerSallary + sellerTotalSells * SELLING_COMMISSION;

        Console.WriteLine(String.Format("TOTAL = R$ {0:0.00}", sellerTotalPayment));
    }
}