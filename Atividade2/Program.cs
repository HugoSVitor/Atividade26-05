using System;
using Atividade2.Classes;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            
                    Insira o tipo de jogador você pretende ver cadastrar:
                    a- Ataque
                    d- Defesa
                    m- Meio Campo
                    ");
            string opcaoCadastrar = Console.ReadLine().ToLower();

            switch (opcaoCadastrar)
            {
                case "a":
                    JogadorAtaque a = new JogadorAtaque();
                    a.InserirInfo();
                    a.CalcularIdade();
                    a.TempoAposentar();
                    break;
                case "d":
                    JogadorDefesa d = new JogadorDefesa();
                    d.InserirInfo();
                    d.CalcularIdade();
                    d.TempoAposentar();
                    break;
                case "m":
                    JogadorMeioCampo m = new JogadorMeioCampo();
                    m.InserirInfo();
                    m.CalcularIdade();
                    m.TempoAposentar();
                    break;
                default:
                    break;
            }
            
        }
    }
}