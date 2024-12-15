using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class EscolhaDeBebida
    {
        public static void Main(string[] args)
        {
            bool sucesso = true;
            
            while (sucesso) {

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Esolha uma bebida");
                Console.WriteLine(" 1 - Café \n 2 - Chá \n 3 - Suco \n 4 - Refrigerante \n 5 - Sair do Console");
                byte opcao = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("---------------------------------------");

                switch (opcao)
                {
                    case 1:
                        sucesso = false;
                        Console.WriteLine("HNMMMMMM CAFÉZIN TOTOSO");
                        break;
                    case 2:
                        sucesso = false;
                        Console.WriteLine("Eca chá");
                        break;
                    case 3:
                        sucesso = false;
                        Console.WriteLine("hnmmmm suco");
                        break;
                    case 4:
                        sucesso = false;
                        Console.WriteLine("hnmmmm refrigerante");
                        break;
                    case 5:
                        sucesso = false;
                        Console.WriteLine("Saindo");
                        break;
                    default:
                        Console.WriteLine("Tente novamentee");
                        break;
                }
            }
        }
    }
}
