using System;
namespace Todos
{
  class Program
{
  public static void Main(string[] args)
  {
    Ex010101 ex01 = new Ex010101();
    Console.WriteLine("Digite um valor para Largura :");
    ex01.Largura = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite um valor para Altura");
    ex01.Altura = double.Parse(Console.ReadLine());

    Console.WriteLine(ex01);



  }

}
}
