using System;

namespace Atividade2.Classes
{
    public class JogadorAtaque : Jogador
    {
        public int idadeAposentadoria = 35; 

        public void TempoAposentar(){
            if (idadeAposentadoria > idadeJogador)
            {
                int tempoAposentadoria = idadeAposentadoria - idadeJogador;
                Console.WriteLine($"O jogador {nomeJogador} poderá se aposentar em {tempoAposentadoria}!");
            }else
            {
                Console.WriteLine($"O jogador {nomeJogador} ja está aposentado!");
            }
        }
    }
}