using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira o primeiro número
        Console.Write("Digite o primeiro número: ");
        
        // Lê o primeiro número como uma string e converte para double
        double numero1 = Convert.ToDouble(Console.ReadLine());

        // Solicita ao usuário que insira o segundo número
        Console.Write("Digite o segundo número: ");
        
        // Lê o segundo número como uma string e converte para double
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Calcula a média aritmética dos dois números
        double media = (numero1 + numero2) / 2;

        // Apresenta o resultado da média aritmética
        Console.WriteLine($"A média dos números {numero1} e {numero2} é: {media}");

        // Solicita ao usuário que insira o preço do produto
        Console.Write("Digite o preço do produto: ");
        
        // Lê o preço do produto como uma string e converte para double
        double precoProduto = Convert.ToDouble(Console.ReadLine());

        // Calcula o valor do produto acrescido de 10%
        double novoPreco = precoProduto + (precoProduto * 0.10);

        // Apresenta o valor do produto com o acréscimo de 10%
        Console.WriteLine($"O valor do produto com 10% de acréscimo é: {novoPreco:C}");

        // Aguarda o usuário pressionar uma tecla para encerrar
        Console.ReadKey();
    }

    public void calcularDezPorcento(int value) {
      Console.Write("Digite o preço do produto: ");

      double inputValue = Convert.ToDouble(Console.ReadLine());

      value = inputValue + (inputValue * 0.10);

      return value;
    }

    calcularDezPorcento()
}
