using System;

class URI {
    const double CONSUMO_VEICULO = 12;

    static void Main(string[] args){
        double horasViagem;
        double velocidadeMedia;
        double combustivelNecessario;

        horasViagem = int.Parse(Console.ReadLine());
        velocidadeMedia = int.Parse(Console.ReadLine());

        combustivelNecessario = velocidadeMedia / CONSUMO_VEICULO * horasViagem;

        Console.WriteLine(String.Format("{0:0.000}", combustivelNecessario));
    }
}