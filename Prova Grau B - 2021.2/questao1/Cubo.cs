using System;
namespace provaGB
{
    public class Cubo : FormaTridimensional
    {
        public Cubo(int altura, int largura, int profundidade) : base(altura, largura, profundidade)
        {

        }
        public override void getArea()
        {
            this.area = Math.Pow(largura,2);
            System.Console.WriteLine("Area do cubo: "+area);
        }

        public override void getVolume()
        {
            this.volume = largura * altura * profundidade;
             System.Console.WriteLine("Volume do cubo: "+volume);

        }
    }
}