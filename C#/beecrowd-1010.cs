using System;
using System.Collections.Generic;

class URI {
    static void Main(string[] args) { 
        Dictionary<string, Peca> pecas = new Dictionary<string, Peca>();
        dynamic inputValues;
        double totalPrice;

        for(int i = 1; i <= 2; i++){
            inputValues = Console.ReadLine().Split();
            pecas.Add(String.Format("peca{0}", i), new Peca(
                int.Parse(inputValues[0]),
                int.Parse(inputValues[1]),
                double.Parse(inputValues[2])
                ));
        }

        totalPrice = pecas["peca1"].GetPrice() * pecas["peca1"].GetQuantity() + pecas["peca2"].GetPrice() * pecas["peca2"].GetQuantity();

        Console.WriteLine(String.Format("VALOR A PAGAR: R$ {0:0.00}", totalPrice));
    }
}

class Peca {
    private int id;
    private int quantity;
    private double price;
    
    public Peca(int id, int quantity, double price){
        this.id = id;
        this.quantity = quantity;
        this.price = price;
    }

    public int GetId(){
        return id;
    }

    public int GetQuantity(){
        return quantity;
    }

    public double GetPrice(){
        return price;
    }
}