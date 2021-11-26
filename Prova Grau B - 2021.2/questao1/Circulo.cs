using System;
namespace provaGB
{
    public class Circulo : FormaBidimensional
    {
        public Circulo(int altura, int largura, char carac) : base(altura, largura, 1, carac)
        {
            
        }

        public void desenharCirculo()
        {
            System.Console.WriteLine("Circulo");
            System.Console.WriteLine();
            System.Console.Write(" ");
            this.desenhar(largura-1);
            System.Console.WriteLine();
            this.desenhar(largura);
            System.Console.WriteLine();
            System.Console.Write(" ");
            this.desenhar(largura-1);
            System.Console.WriteLine();
        }

        public override void getArea()
        {
            this.area = Math.Pow((this.altura / 2),2) * Math.PI;
            System.Console.WriteLine("Area do circulo: "+area);
        }
    }
    
}