namespace questao2
{
    public class CamaroteInf : Vip
    {
        public string local;
        public CamaroteInf(float valorAdc, string local) : base(valorAdc)
        {
            this.local = local;
            System.Console.WriteLine("Seu assento é: "+local);
            System.Console.WriteLine();
        }



    }
}