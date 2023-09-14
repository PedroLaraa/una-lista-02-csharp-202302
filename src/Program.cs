using System;

class Program
{
    static void Main()
    {
      // INVOCA FUNÇÕES SEPARADAMENTE

      // MediaAritmetica();
      // CalcularDezPorcento();
      // FahrenheitParaGraus();
      JurosComposto();
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

    static void FahrenheitParaGraus() {
      Console.Write("Digite a temperatura: ");

      double temperaturaGraus = (Convert.ToDouble(Console.ReadLine()) - 32) / 1.8;

      Console.WriteLine($"A temperatura em graus é: {Math.Round(temperaturaGraus, 1)}ºC");
    }

    static void JurosComposto() {

      Console.Write("Qual o capital aplicado: ");
      double capital = Convert.ToDouble(Console.ReadLine());

      Console.Write("Qual a taxa de juros (%): ");
      double i = Convert.ToDouble(Console.ReadLine()) / 100;

      Console.Write("Qual o prazo de aplicação em meses: ");
      int n = Convert.ToInt32(Console.ReadLine());

      double montante = capital * Math.Pow(1 + i, n); 

      Console.WriteLine($"O seu montante final será {montante:C}");
    }

    static void SalarioBruto() {
      
    }

};
