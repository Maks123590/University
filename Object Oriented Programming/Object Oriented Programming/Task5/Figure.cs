namespace Task5
{
    using System;

    public abstract class Figure : IFigure
    {
        public virtual double GetPerimeter()
        {
            throw new Exception("Метод должен быть переопределен!");
        }

        public virtual double GetArea()
        {
            throw new Exception("Метод должен быть переопределен!");
        }
    }
}