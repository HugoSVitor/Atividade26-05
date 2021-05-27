using System;
using Atividade1.Classes;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetirProcesso = false;
            
            Console.WriteLine("Olá , deseja iniciar o sistema? (s/n)");
            string iniciarSN = Console.ReadLine().ToLower();

            switch (iniciarSN)
            {
                case "s":
                    Console.WriteLine(@"               
                    Qual tipo de elevador você deseja utilizar?
                    
                    1- Elevador Social
                    2- Elevador de Serviço
                    ");
                    int tipoElevador = int.Parse(Console.ReadLine());

                    switch (tipoElevador)
                    {
                        case 1:
                            ElevadorSocial s = new ElevadorSocial();
                            
                            s.Inicializar();
                            
                            do
                            {
                                Console.WriteLine($"Há {s.quantidadePessoas} pessoas no elevador!");
                                Console.WriteLine($"Andar atual: {s.andarAtual}");
                                Console.WriteLine(@"
                                   Qual ação será executada
                                   
                                   1- Entrar
                                   2- Sair
                                   3- Subir
                                   4- Descer
                                   5- Sair do sistema
                                   ");
                                int opcaoElevador = int.Parse(Console.ReadLine());

                                switch (opcaoElevador)
                                {
                                    case 1:
                                        s.Entrar();
                                        repetirProcesso = true;
                                        break;
                                    case 2:
                                        s.Sair();
                                        repetirProcesso = true;
                                        break;
                                    case 3:
                                        s.Subir();
                                        repetirProcesso = true;
                                        break;
                                    case 4:
                                        s.Descer();
                                        repetirProcesso = true;
                                        break;
                                    case 5:
                                        Console.WriteLine($"Até mais!");
                                        repetirProcesso = false;
                                        break;  
                                    default:
                                        break;
                                }
                                

                            } while (repetirProcesso);

                            break;
                        case 2:
                            ElevadorServico servico = new ElevadorServico();
                            
                            servico.Inicializar();
                            
                            do
                            {
                                Console.WriteLine($"Há {servico.quantidadePessoas} pessoas no elevador!");
                                Console.WriteLine($"Há {servico.quantidadeCaixas} caixas no elevador!");
                                Console.WriteLine($"Andar atual: {servico.andarAtual}");
                                Console.WriteLine(@"
                                   Qual ação será executada
                                   
                                   1- Entrar
                                   2- Sair
                                   3- Subir
                                   4- Descer
                                   5- Adicionar Caixa
                                   6- Retirar Caixa
                                   7- Sair do sistema
                                   ");
                                int opcaoElevador = int.Parse(Console.ReadLine());

                                switch (opcaoElevador)
                                {
                                    case 1:
                                        servico.Entrar();
                                        repetirProcesso = true;
                                        break;
                                    case 2:
                                        servico.Sair();
                                        repetirProcesso = true;
                                        break;
                                    case 3:
                                        servico.Subir();
                                        repetirProcesso = true;
                                        break;
                                    case 4:
                                        servico.Descer();
                                        repetirProcesso = true;
                                        break;
                                    case 5:
                                        servico.AdicionarCaixas();
                                        repetirProcesso = true;
                                        break;
                                    case 6:
                                        servico.RetirarCaixas();
                                        repetirProcesso = true;
                                        break;
                                    case 7:
                                        Console.WriteLine($"Até mais!");
                                        repetirProcesso = false;
                                        break;  
                                    default:
                                        break;
                                }
                                

                            } while (repetirProcesso);
                            break;
                        default:
                            break;
                    }
                    
                    break;
                case "n":
                    Console.WriteLine("Sistema não iniciado!");
                    break;
                default:
                    break;
            }
        }
    }
}
