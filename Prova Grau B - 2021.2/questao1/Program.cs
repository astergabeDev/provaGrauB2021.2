using System;

namespace provaGB
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Forma[] formas;

            Quadrado quadrado1 = new Quadrado(4,4,'X');
            quadrado1.desenharQuadrado();
            quadrado1.getArea();

            Triangulo t1 = new Triangulo(5,5,'Y');
            t1.desenharTriangulo();
            t1.getArea();

            Circulo c1 = new Circulo(10,10,'O');
            c1.desenharCirculo();
            c1.getArea();
            
            Cubo cu1 = new Cubo(5,5,5);
            cu1.getArea();
            cu1.getVolume();

            Tetraedro tetra = new Tetraedro(5,5,5);
            tetra.getArea();
            tetra.getVolume();

            Esfera e1 = new Esfera(12,6,12);
            e1.getArea();
            e1.getVolume();

        }
    }
}
