using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class CategoriaDeFilme
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual a classificação etária?");
            string classificacao = Console.ReadLine();

            switch (classificacao) {
                case "g":
                    Console.WriteLine("Livre para todos os publicos");
                    break;
                case "pg":
                    Console.WriteLine("Maior de 10 anos");
                    break;
                case "pg-13":
                    Console.WriteLine("Maior de 13 anos");
                    break;
                case "R":
                    Console.WriteLine("Maior de 18 anos");
                    break;
                default:
                    Console.WriteLine("Não existe essa opção tente uma das alternativas \n g \n pg \n pg-13 \n r");
                    break;
            }
        }
    }
}
