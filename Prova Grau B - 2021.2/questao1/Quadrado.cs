namespace provaGB
{
    public class Quadrado : FormaBidimensional
    {
        public Quadrado(int altura, int largura, char carac) : base(altura, largura, 1, carac)
        {
            
        }

        public void desenharQuadrado()
        {
            System.Console.WriteLine("Quadrado");
            System.Console.WriteLine();
            for (int i = 0; i < altura; i++)
            {
                this.desenhar(largura);

                System.Console.WriteLine();
            }
        }

        public override void getArea()
        {
            this.area = this.altura * this.largura;
            System.Console.WriteLine("Area do quadrado: "+area);
        }
    }
}