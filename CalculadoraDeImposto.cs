using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class CalculadoraDeImposto
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do seu salario");
            float salario = Convert.ToSingle(Console.ReadLine());

            byte faixaSalario;
            if (salario <= 1500)
            {
                faixaSalario = 1;
            }else if(salario > 1501 && salario <= 3000){
                faixaSalario = 2;
            }
            else
            {
                faixaSalario= 3;
            }


            
            switch (faixaSalario)
            {
                case 1:
                    double impostoCinco = 0.05 * salario;
                    Console.WriteLine("O Valor do imposto é " + impostoCinco);
                    break;
                case 2:
                    double impostoDez = 0.1 * salario;
                    Console.WriteLine("O Valor do imposto é " + impostoDez);
                    break;
                case 3:
                    double impostoQuinze = 0.15 * salario;
                    Console.WriteLine("O Valor do imposto é " + impostoQuinze);
                    break;
                default:
                    Console.WriteLine("Não digitou um valor correto");
                    break;
            }
        }
    }
}
