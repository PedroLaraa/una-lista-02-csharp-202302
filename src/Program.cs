using System;

class Program
{
    static void Main()
    {
      // INVOCA FUNÇÕES SEPARADAMENTE
      // CalcularDezPorcento();

      ParImpar();
    }

    static void MediaAritmetica(double value1, double value2, double media) {

      Console.Write("Digite valor 1: ");
      value1 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Digite valor 2: ");
      value2 = Convert.ToDouble(Console.ReadLine());

      media = (value1 + value2) / 2;

      Console.WriteLine($"A média dos números {value1} e {value2} é: {media}");
    }

    static void CalcularDezPorcento () {
      Console.Write("Digite o preço do produto: ");

      double inputValue = Convert.ToDouble(Console.ReadLine());

      double newValue = inputValue + (inputValue * 0.10);

      Console.WriteLine($"O valor do produto com 10% de acréscimo é: {newValue:C}");
    }

    static void ParImpar() {
      Console.Write("Digite o número: ");

      double value = Convert.ToDouble(Console.ReadLine());

      string result = value > 100 ? "Maior" : "Menor";

      Console.WriteLine(result);
    }

};
