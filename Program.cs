using System;

namespace Tabuadaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicador, x, numero; 

          Console.Write("Digite um número para exibir a tabuada: ");
          numero = Int32.Parse(Console.ReadLine());
          
          for (x = 1; x<= 10; x ++)
          {
                multiplicador = numero*x;
                Console.WriteLine(numero+"x" + x + "=" + multiplicador);
          }
          Console.ReadKey();
        }
    }
}
