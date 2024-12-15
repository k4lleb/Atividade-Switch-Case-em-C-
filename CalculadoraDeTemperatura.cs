using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class CalculadoraDeTemperatura
    {
        public static void Main(string[] args)
        {
            bool confere = true;
            while (confere) { 
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Escolhar uma opção para converter");
                Console.WriteLine(" 1 - Celcius para Fahrenheit \n 2 - Fahrenheit para Celcius \n 3 - Sair do programa");
                Console.WriteLine("------------------------------------------");
                byte opcao = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Quantos Graus?");
                float graus  = Convert.ToSingle(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        confere = false;
                        double fahrenheit = (graus * 5 / 9) + 32;
                        Console.WriteLine("O Valor de " + graus + "C em Fahrenheit fica " + fahrenheit + "F");

                        break;
                    case 2:
                        confere = false;
                        double celcius = (graus - 32) * (5 / 9);
                        Console.WriteLine("O Valor de " + graus + "F em celcius fica " + celcius + "C");
                        
                        break;
                    case 3:
                        confere = false;
                        Console.WriteLine("Finalizando terminal");
                        break;
                }
            }
        }
    }
}
