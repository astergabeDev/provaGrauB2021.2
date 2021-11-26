namespace provaGB
{
    public class Triangulo : FormaBidimensional
    {
        public Triangulo(int altura, int largura, char carac) : base(altura, largura, 1, carac)
        {
            
        }

        public void desenharTriangulo()
        {
            System.Console.WriteLine("Triangulo");
            for (int i = 1; i <= altura; i++)
            {
                this.desenhar(i);
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }

        public override void getArea()
        {
            this.area = (this.altura * this.largura) / 2;
            System.Console.WriteLine("Area do triangulo: "+area);
        }
    }
}