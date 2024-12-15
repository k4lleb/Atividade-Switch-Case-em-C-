using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class Idade
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade: ");
            byte idade = Convert.ToByte(Console.ReadLine());

            int faixaEtaria;

            if (idade >= 0 && idade <= 12)
            {
                faixaEtaria = 1;
            }
            else if (idade >= 13 && idade <= 17)
            {
                faixaEtaria = 2;
            }
            else if (idade >= 18 && idade <= 59)
            {
                faixaEtaria = 3;
            }
            else if (idade >= 60)
            {
                faixaEtaria = 4;
            }
            else
            {
                faixaEtaria = 0;
            }

            switch (faixaEtaria)
            {
                case 1:
                    Console.WriteLine("vc é uma Criança");
                    break;
                case 2:
                    Console.WriteLine("vc é uma Adolescente");
                    break;
                case 3:
                    Console.WriteLine("vc é uma Adulto");
                    break;
                case 4:
                    Console.WriteLine("vc é uma Idoso");
                    break;
                default:
                    Console.WriteLine("O Numero que vc digitou não condiz com uma de nossa idades");
                    break;
            }
        }
    }
}
