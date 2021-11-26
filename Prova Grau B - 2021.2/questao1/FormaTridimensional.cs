namespace provaGB
{
    public abstract class FormaTridimensional : Forma
    {
        public double area;
        public double volume;
        public int altura; public int largura;  public int profundidade;

        public FormaTridimensional(int altura, int largura, int profundidade)
        {
            this.altura = altura;
            this.largura = largura;
            this.profundidade = largura;
        }



        public abstract void getArea();

        public abstract void getVolume();
    }
}