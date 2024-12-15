using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class diaDaSemana
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero que corresponde a um dia na semana: ");
            byte semana = Convert.ToByte(Console.ReadLine());

            switch (semana)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                case 3:
                    Console.WriteLine("Terça");
                    break;
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                case 5:
                    Console.WriteLine("Quinta");
                    break ;
                case 6:
                    Console.WriteLine("Sexta");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;

                default:
                    Console.WriteLine("Não é um numero equivalente a semana");
                    break;
            }
        }
    }
}
