using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAvaliacaoCursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int cont_a = 0;
            int cont_d = 0;
            int cont_e = 0;
            int cont_m = 0;
            Console.WriteLine("Deseja iniciar o programa? S/N" );
            string resp = Console.ReadLine().ToUpper();
            while (resp == "S")
            {
                Console.WriteLine("Qual curso deseja se matricular: (A)admin (D)desenvolvimento (E)edificações (M)mecatronica" );
                string resp_a = Console.ReadLine().ToUpper();

                switch (resp_a)
                {
                    case "A":
                    Console.WriteLine("Deseja matricular o aluno em adm? s/n" );
                    string resp_m = Console.ReadLine().ToLower();
                    if (resp_m == "s" && cont_a < 5) 
                        {
                            Console.WriteLine("Aluno matriculado");
                            cont++;
                            cont_a++;
                        }
                    else
                        {
                            Console.WriteLine("Quantidade de vagas atingidas");
                        }
                    break;
                    case "D":
                        Console.WriteLine("Deseja matricular o aluno em ds? s/n");
                         resp_m = Console.ReadLine().ToLower();
                        if (resp_m == "s" && cont_d < 5)
                        {
                            Console.WriteLine("Aluno matriculado");
                            cont++;
                            cont_d++;
                        }
                        else
                        {
                            Console.WriteLine("Quantidade de vagas atingidas");
                        }
                        break;
                    case "E":
                        Console.WriteLine("Deseja matricular o aluno em edif? s/n");
                        resp_m = Console.ReadLine().ToLower();
                        if (resp_m == "s" && cont_e < 5)
                        {
                            Console.WriteLine("Aluno matriculado");
                            cont++;
                            cont_e++;
                        }
                        else
                        {
                            Console.WriteLine("Quantidade de vagas atingidas");
                        }
                        break;
                    case "M":
                        Console.WriteLine("Deseja matricular o aluno em meca? s/n");
                        resp_m = Console.ReadLine().ToLower();
                        if (resp_m == "s" && cont_m < 5)
                        {
                            Console.WriteLine("Aluno matriculado");
                            cont++;
                            cont_m++;
                        }
                        else
                        {
                            Console.WriteLine("Quantidade de vagas atingidas");
                        }
                        break;
                    default: Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Deseja matricular mais um aluno? S/N" );
                resp = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("A quantidade de alunos matriculados foi: "+cont);
            Console.WriteLine("A quantidade de alunos matriculados em adm foi: " + cont_a);
            Console.WriteLine("A quantidade de alunos matriculados em ds foi: " + cont_d);
            Console.WriteLine("A quantidade de alunos matriculados em edif foi: " + cont_e);
            Console.WriteLine("A quantidade de alunos matriculados em meca foi: " + cont_m);
            Console.ReadKey();

        }
    }
}
