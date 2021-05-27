using System;

namespace Atividade1.Classes
{
    public class ElevadorServico : Elevador
    {
        public int quantidadeCaixas = 0;
        public int capacidadeCaixas;
        private int adicionarCaixas;
        private int retirarCaixas;

        public override void Inicializar()
        {
            Console.WriteLine("Quantos andares há no prédio?");
            quantidadeAndares = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a capacidade máxima de pessoas?");
            capacidadeElevador = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a capacidade máxima de caixas?");
            capacidadeCaixas = int.Parse(Console.ReadLine());
        }

        public void AdicionarCaixas()
        {
            Console.WriteLine("Quantas caixas serão adicionadas?");
            adicionarCaixas = int.Parse(Console.ReadLine());

            quantidadeCaixas = quantidadeCaixas + adicionarCaixas;

            if (quantidadeCaixas <= capacidadeCaixas)
            {
                Console.WriteLine($"{adicionarCaixas} caixas adicionadas!");
            }
            else
            {
                Console.WriteLine("Não é possível adicionar mais caixas!");
            }
        }

        public void RetirarCaixas()
        {
            if (quantidadeCaixas != 0)
            {
                Console.WriteLine("Quantas caixas serão retiradas?");
                retirarCaixas = int.Parse(Console.ReadLine());

                quantidadeCaixas = quantidadeCaixas - retirarCaixas;

                Console.WriteLine($"Foram retiradas {retirarCaixas} caixas do elevador!");
            }
            else
            {
                Console.WriteLine("O elevador esta vazio, é impossível retirar alguma caixa!");
            }

        }
    }
}