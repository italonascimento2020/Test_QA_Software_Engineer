using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wex_QA_Test
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            //Session1_1();

            Session1_2();

        }
        private static void Session1_1()
        {
            int number;

            Console.WriteLine("Session 1 #1 \n");

            while (true)
            {
                Console.WriteLine("Insira um valor: \n");

                string valor = Console.ReadLine();

                if (int.TryParse(valor, out number))
                {
                    if (number % 3 == 0 && !valor.Contains("5"))
                    {
                        Console.WriteLine("Cira \n");
                    }
                    else if (number % 3 != 0 && valor.Contains("5"))
                    {
                        Console.WriteLine("Dinha \n");
                    }
                    else if (number % 3 == 0 && valor.Contains("5"))
                    {
                        Console.WriteLine("CiraDinha \n");
                    }
                }
                else
                {
                    Console.WriteLine("Digite um número inteiro \n");
                }
            }
        }

        private static void Session1_2()
        {
            int number;

            Console.WriteLine("Session 1 #2 \n");

            while (true)
            {
                Console.WriteLine("Insira o tamanho da base da arvore que deseja: \n");

                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    string star = "* ";

                    string space = " ";

                    string str_concat = String.Empty;

                    int number_star = number;

                    int number_space = number;

                    int number_initial = number;
                    
                    while(number>0)
                    {
                        number_space = number_initial - number_space;

                        while (number_space > 0)
                        {
                            str_concat += space;
                            
                            number_space--;
                        }

                        while (number_star > 0)
                        {
                            str_concat += star;

                            number_star--;
                        }

                        Console.WriteLine(str_concat);

                        number--;

                        number_star = number;

                        number_space = number;

                        str_concat = String.Empty;
                    }
                }
                else
                {
                    Console.WriteLine("Digite um número inteiro \n");
                }
            }
        }
    }
}
