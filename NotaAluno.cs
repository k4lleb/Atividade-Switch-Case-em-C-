using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSwitch
{
    internal class NotaAluno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do Aluno para converter: ");
            byte nota = Convert.ToByte(Console.ReadLine());

            string letraNota;

            if (nota == 10 || nota == 9)
            {
                letraNota = "A";
            }
            else if (nota == 8 || nota == 7)
            {
                letraNota = "B";
            }
            else if (nota == 6 || nota == 5)
            {
                letraNota = "C";
            }
            else if (nota == 4 || nota == 3)
            {
                letraNota = "D";
            }
            else if (nota <= 2)
            {
                letraNota = "F";
            }
            else
            {
                letraNota = "Nota invalida!";
            }


            switch (letraNota)
            {
                case "A":
                    Console.WriteLine("Sua nota sera A");
                    break;
                case "B":
                    Console.WriteLine("Sua nota sera B");
                    break;
                case "C":
                    Console.WriteLine("Sua nota sera C");
                    break;
                case "D":
                    Console.WriteLine("Sua nota sera D");
                    break;
                case "F":
                    Console.WriteLine("Sua nota sera F");
                    break;
                default:
                    Console.WriteLine("Sua nota não está até 10");
                    break;
            }
        }
    }
}
