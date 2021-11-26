using System;

namespace questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorAdc = 20;
            float valorMaisAdc = 20;

            System.Console.WriteLine("Insira o ingresso desejado (1 - Normal, 2 - VIP): ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Normal normal = new Normal();
                normal.getIngresso();
            }
            else
            {
                System.Console.WriteLine("Insira o camarote desejado (1 - inferior, 2 - superior): ");
                int escolha2 = int.Parse(Console.ReadLine());
                if (escolha2 == 1)
                {
                    CamaroteInf camaroteInf = new CamaroteInf(valorAdc,"A5");
                    camaroteInf.getValue();
                }
                else
                {
                    CamaroteSup camaroteSup = new CamaroteSup(valorAdc, valorMaisAdc,"61");
                    camaroteSup.mostrarValor();
                }
            }
        }
    }
}
