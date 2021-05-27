using System;

namespace Atividade1.Classes
{
    public class Elevador
    {
        public int andarAtual;
        public int quantidadeAndares;
        public int capacidadeElevador;
        public int pessoasElevador;
        public bool repetirEntar = false;
        public int adicionarPessoas;
        public int retirarPessoas;
        public int quantidadePessoas;
        public int subirAndar;
        public int andaresSubidos;
        public int descerAndar;
        public int andaresDescidos;

        public virtual void Inicializar()
        {
            Console.WriteLine("Quantos andares há no prédio?");
            quantidadeAndares = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a capacidade máxima do elevador?");
            capacidadeElevador = int.Parse(Console.ReadLine());
        }

        public void Entrar()
        {
            Console.WriteLine("Quantas pessoas entraram?");
            adicionarPessoas = int.Parse(Console.ReadLine());
            quantidadePessoas = pessoasElevador + adicionarPessoas;

            if (quantidadePessoas <= capacidadeElevador)
            {
                repetirEntar = true;
                Console.WriteLine($"{adicionarPessoas} pessoas entraram no elevador!");
            }
            else
            {
                repetirEntar = false;
                Console.WriteLine("O capacidade do elevador não é suficiente para que entre essa quantidade de pessoas!");
            }
        }

        public void Sair()
        {
            if (quantidadePessoas != 0)
            {
                Console.WriteLine("Quantas pessoas sairam?");
                retirarPessoas = int.Parse(Console.ReadLine());
                quantidadePessoas = quantidadePessoas - retirarPessoas;
            }
            else
            {
                Console.WriteLine("O elevador esta vazio, é impossível retirar alguem!");
            }
        }
        public void Subir()
        {
            Console.WriteLine("Quantos andares você deseja subir?");
            subirAndar = int.Parse(Console.ReadLine());

            andarAtual = andarAtual + subirAndar;

            if (andarAtual <= quantidadeAndares)
            {
                Console.WriteLine($"Você chegou no {andarAtual}º andar");
            }
            else
            {
                Console.WriteLine("Não é possível subir essa quantidade de andares!");
            }
        }

        public void Descer()
        {

            Console.WriteLine("Quantos andares você deseja descer?");
            descerAndar = int.Parse(Console.ReadLine());

            andarAtual = andarAtual - descerAndar;

            if (andarAtual <= quantidadeAndares && andarAtual >= 0)
            {
                Console.WriteLine($"Você chegou no {andarAtual}º andar");
            }
            else
            {
                Console.WriteLine("Não é possível descer essa quantidade de andares!");
            }
        }
    }
}