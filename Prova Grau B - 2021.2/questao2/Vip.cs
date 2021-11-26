namespace questao2
{
    public class Vip : Ingresso
    {
        public float valorAdc;


        public Vip(float valorAdc)
        {
            this.valorAdc = valorAdc;
        }

        public void getValue()
        {
            System.Console.WriteLine($"Valor do ingresso VIP: {valorAdc + valor}");
            System.Console.WriteLine();
        }
    }
}