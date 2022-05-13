using System;

class URI {
    const int DIAS_NO_MES = 30;
    const int DIAS_NO_ANO = 365;
    
    static void Main(string[] args){
        int dias;
        int meses;
        int anos;

        dias = int.Parse(Console.ReadLine());
        
        anos = dias / DIAS_NO_ANO;
        meses = dias % DIAS_NO_ANO / DIAS_NO_MES;
        dias = dias % DIAS_NO_ANO % DIAS_NO_MES;

        Console.WriteLine(String.Format("{0} ano(s)", anos));
        Console.WriteLine(String.Format("{0} mes(es)", meses));
        Console.WriteLine(String.Format("{0} dia(s)", dias));
    }
}