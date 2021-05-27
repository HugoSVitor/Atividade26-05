using System;
using Atividade3.Classes;

namespace Atividade3
{
    class Program
    {
        public int acucarOpcao;
        public int acucarGramasEscolhidas;
        static void Main(string[] args)
        {
            bool maquinaCafeOn = false;

            MaquinaCafe c = new MaquinaCafe();

            do
            {
                Console.WriteLine(@"
                =============== Cafeteira =================
                  1- Fazer café com açúcar
                  2- Fazer café com açúcar a sua escolha
                  3- Fazer café sem açúcar
                  4- Desligar
                ===========================================
            ");
            int opcaoCafeiteira = int.Parse(Console.ReadLine());

            switch (opcaoCafeiteira)
            {
                case 1:
                    c.FazerCafe(c.acucarGramasEscolhidas);
                    maquinaCafeOn = true;
                    break;
                case 2:
                    c.FazerCafe();
                    maquinaCafeOn = true;
                    break;
                case 3:
                    Console.WriteLine(@"
                        HMMMMMM CAFÉZIN BÃO!
                               __
                               | |_
                               |  |_
                               |_ _|
                                | |
                               | |
                        _______|_|_
                        |         |____
                        |    ||   |   |
                        |    ||   |___|
                        |_________|
                        
                        
                        ");
                        maquinaCafeOn = true;
                    break;
                case 4:
                    Console.WriteLine("Desligando...");
                    maquinaCafeOn = false;
                    break;
                default:
                    break;
            }
            } while (maquinaCafeOn);

            
            
        }
    }
}
