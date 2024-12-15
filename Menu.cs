using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class Menu
    {
        public static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(" 1- Olá, Mundo!\n 2- Bem-vindo ao C#\n 3- Sair do Programa\n");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Escolha uma opção:");
                byte opcao = Convert.ToByte(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Olá, Mundo!");
                        break;

                    case 2:
                        Console.WriteLine("Bem-vindo ao C#");
                        break;

                    case 3:
                        continuar = false;
                        Console.WriteLine("Programa encerrado");
                        break;

                    default:
                        Console.WriteLine("Essa opção não condiz com alguma opção tente novamente");
                        break;
                }




            }
        }
    }
}
