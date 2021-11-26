namespace questao2
{
    public class CamaroteSup : Vip
    {
        public string local;
        public float valorMaisAdc;
        public CamaroteSup(float valorAdc, float valorMaisAdc, string local) : base(valorAdc)
        {
            this.local = local;
            this.valorMaisAdc = valorMaisAdc;
            System.Console.WriteLine("Seu assento é: "+local);
            System.Console.WriteLine();
        }
        public void mostrarValor()
        {
            System.Console.WriteLine($"Valor do ingresso VIP (Camarote Superior): {valorAdc + valor + valorMaisAdc}");
        }

    }
}