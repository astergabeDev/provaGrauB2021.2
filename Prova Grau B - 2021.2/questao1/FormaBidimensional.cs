namespace provaGB
{
    public abstract class FormaBidimensional : Forma
    {
        public double area;
        public int tamanho;
        public int altura; public int largura;
        char carac;
        public FormaBidimensional(int altura, int largura, int tamanho, char carac)
        {
            this.altura = altura;
            this.largura = largura;
            this.tamanho = tamanho;
            this.carac = carac;
        }


        public abstract void getArea();
        public void desenhar(int tamanho = -1)
        {
            int qntChar = this.tamanho;
            if (tamanho > 0)
            {
                qntChar = tamanho;
            }
            for (int i = 0; i < qntChar; i++)
            {
                System.Console.Write(this.carac);
                System.Console.Write(" ");
            }
            //System.Console.WriteLine(" ");
        }
    }
}