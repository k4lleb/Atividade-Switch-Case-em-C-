using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class Calculadora
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int nmr1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite um numero");
            int nmr2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o tipo de operação (ex *, /, -, +)");
            char operacao = Console.ReadLine()[0];

            switch (operacao) {
                case '-':
                    int resultado = nmr1 - nmr2;
                    Console.WriteLine("O Resultado é " + resultado);
                    break;

                case '+':
                    int resultado1 = nmr1 + nmr2;
                    Console.WriteLine("O Resultado é " + resultado1);
                    break;

                case '*':
                    int resultado2 = nmr1 * nmr2;
                    Console.WriteLine("O Resultado é " + resultado2);
                    break;

                case '/':
                    int resultado3 = nmr1 / nmr2;
                    Console.WriteLine("O Resultado é " + resultado3);
                    break;

                default:
                    Console.WriteLine("Essa operação não corresponde corretamente");
                    break;

            }


        }
    }
}
