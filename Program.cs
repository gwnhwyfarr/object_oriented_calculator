using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
            int historico;
            string continuar;
            do {
                Console.WriteLine("Digite um nomero");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro numero");
                numero2 = int.Parse(Console.ReadLine());

                resultado = numero1 + numero2;
                Console.WriteLine("Total:" + resultado);
                Console.ReadKey();
                Console.WriteLine("Deseja fazer outra operação?

[s/n]");
                continuar = Console.ReadLine();
                while ((continuar != "N" && continuar != "n") && 

(continuar != "s" && continuar != "S"));
                {
                    Console.WriteLine("opção incorreta");
                    continuar = Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine("Resultado anterior:" + 

resultado);
            }while(continuar == "sim" || continuar == "s");
        }
    }
}
