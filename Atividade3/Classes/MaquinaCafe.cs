using System;

namespace Atividade3.Classes
{
    public class MaquinaCafe
    {
        public static int acucarDisponivel = 100;
        public int acucarGramasEscolhidas;

        public void FazerCafe()
        {
            if (acucarDisponivel == 0)
            {
                Console.WriteLine("Acabou o açúcar, lamento, o café será feito sem o mesmo!");
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
            }
            else
            {
                Console.WriteLine("Quantas gramas de açúcar você deseja?");
                acucarGramasEscolhidas = int.Parse(Console.ReadLine());

                if (acucarGramasEscolhidas > acucarDisponivel)
                {
                        Console.WriteLine("Açúcar disponível insuficiente");
                }else if (acucarGramasEscolhidas < acucarDisponivel)
                {
                    acucarDisponivel = acucarDisponivel - acucarGramasEscolhidas;
                    Console.WriteLine("Café feito!");
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
                }
            }          
        }

        public void FazerCafe(int acucar){
            Console.WriteLine("Você não escolheu a quantia de açúcar desejada, por tanto foi adicionado a quantia de açúcar padrão do sistema! (10 gramas)");

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
        }
    }
}