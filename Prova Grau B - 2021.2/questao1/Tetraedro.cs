using System;
namespace provaGB
{
    public class Tetraedro : FormaTridimensional
    {
        public Tetraedro(int altura, int largura, int profundidade) : base(altura, largura, profundidade)
        {

        }

        public override void getArea()
        {
            this.area = (Math.Pow(largura,2) * Math.Sqrt(3)) / 4;
            System.Console.WriteLine("Area do tetraedro: "+area);
        }

        public override void getVolume()
        {
            this.volume = (Math.Pow(largura,3) * Math.Sqrt(2)) / 12;
             System.Console.WriteLine("Volume do tetraedro: "+volume);
        }
    }
}