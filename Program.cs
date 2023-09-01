namespace Calculator;
class Program
{
  public static void Main(string[] args)
  {
    Menu();
  }

  static void Menu()
  {
    float resultado = 0;
    Console.Clear();
    Console.WriteLine("Escolha a função desejada:");
    Console.WriteLine("1 -> Soma");
    Console.WriteLine("2 -> Subtração");
    Console.WriteLine("3 -> Multiplicação");
    Console.WriteLine("4 -> Divisão");
    Console.WriteLine("5 -> Sair");
    System.Console.WriteLine("-------------");
    short opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
      case 1: resultado = Soma(); break;
      case 2: resultado = Substracao(); break;
      case 3: resultado = Multiplicacao(); break;
      case 4: resultado = Divisao(); break;
      case 5: Sair(); break;
      default: Console.WriteLine("Opção inválida"); Menu(); break;
    }

    if (opcao > 0 && opcao < 5)
    {
      Console.WriteLine("----------");
      Console.WriteLine($"O resultado da função é: {resultado}");
      Console.ReadKey();
      Menu();
    }
  }

  static void Sair()
  {
    Console.WriteLine("Finalizando o programa"); Environment.Exit(0);
  }

  public static float Soma()
  {
    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("+");

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());
    return v1 + v2;
  }

  static float Substracao()
  {
    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("-");

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());
    return v1 - v2;
  }

  static float Multiplicacao()
  {
    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("*");

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());
    return v1 * v2;
  }

  static float Divisao()
  {
    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("/");

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());
    return v1 / v2;
  }
}