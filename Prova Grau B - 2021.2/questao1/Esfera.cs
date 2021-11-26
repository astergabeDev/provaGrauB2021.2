using System;
namespace provaGB

{
    public class Esfera : FormaTridimensional
    {
        
        public Esfera(int altura, int largura, int profundidade) : base(altura, largura, profundidade)
        {

        }



        public override void getArea()
        {
            this.area = 4 * Math.PI * Math.Pow((altura/2),2);
            System.Console.WriteLine("Area da esfera: "+area);
        }

        public override void getVolume()
        {
            this.volume = (4 * Math.PI * Math.Pow((altura/2),3)) / 3;
             System.Console.WriteLine("Volume da esfera: "+volume);

        }
    }
    
}