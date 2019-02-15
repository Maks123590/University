namespace Task5
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(nameof(ByAbstract));
            ByAbstract();

            Console.WriteLine(nameof(ByInterface));
            ByInterface();

            Console.WriteLine(nameof(NoPolymorphism));
            NoPolymorphism();

            Console.ReadLine();
        }

        public static void ByAbstract()
        {
            Figure rectangle = new Rectangle { a = 10, b = 20 };

            Figure triangle = new Triangle { a = 6.5, b = 4, c = 7 };

            Figure circle = new Circle { r = 10 };

            Print(rectangle, triangle, circle);
        }

        public static void ByInterface()
        {
            IFigure rectangle = new Rectangle { a = 10, b = 20 };

            IFigure triangle = new Triangle { a = 6.5, b = 4, c = 7 };

            IFigure circle = new Circle { r = 10 };

            Print(rectangle, triangle, circle);
        }

        public static void NoPolymorphism()
        {
            Rectangle rectangle = new Rectangle { a = 10, b = 20 };

            Triangle triangle = new Triangle { a = 6.5, b = 4, c = 7 };

            Circle circle = new Circle { r = 10 };

            Print(rectangle, triangle, circle);
        }

        public static void Print(params IFigure[] figures)
        {
            foreach (var figure in figures)
            {
                Console.WriteLine(figure.GetType().Name);
                Console.WriteLine($"P: {figure.GetPerimeter()}");
                Console.WriteLine($"S: {figure.GetArea()}\n");
            }
        }
    }
}
