using System;

namespace Interfaces 
{
    abstract class AbstractShape : IShape
    {
        public Color Color {get; set;}

        public AbstractShape(Color c)
        {
            Color = c;
        }

        /*Como a intenção  não é implementar
        o método aqui, então o método da interface
        é colocado como abstrato*/
        public abstract double Area();
    }
}