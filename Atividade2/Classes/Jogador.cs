using System;

namespace Atividade2.Classes
{
    public abstract class Jogador
    {
        public string nomeJogador;
        public int dataNascimentoJogador;
        public int idadeJogador;
        public string nacionalidadeJogador;
        public float alturaJogador;
        public string pesoJogador;
        public int anoAtual = DateTime.Now.Year;

        public void InserirInfo(){
            Console.WriteLine("Insira o nome do jogador: ");
            nomeJogador = Console.ReadLine();

            Console.WriteLine("Insira o ano de nascimento do jogador: ");
            dataNascimentoJogador = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a nacionalidade do jogador: ");
            nacionalidadeJogador = Console.ReadLine();

            Console.WriteLine("Insira a altura do jogador: ");
            alturaJogador = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o peso do jogador: ");
            pesoJogador = Console.ReadLine();
        }

        public void CalcularIdade(){
            idadeJogador = anoAtual - dataNascimentoJogador;
        }

        
        
    }
}