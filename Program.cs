namespace Practice_1_Dedok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1
            Igrashka toy = new Igrashka("Лялька", "Магазин іграшок", 299, "3+", "Україна");
            toy.PrintInfo();
            Console.WriteLine($"Хеш-код іграшки: {toy.GetHashCode()}");
            Console.WriteLine();
            Console.ReadKey();
            //Task_2 
            Tygr tiger = new Tygr("Амурський тигр", "Ліси", "М'ясоїдний", 60);
            Krokodyl crocodile = new Krokodyl("Нільський крокодил", "Річки", "М'ясоїдний", 5);
            Kenguru kangaroo = new Kenguru("Червоний кенгуру", "Австралія", "Травоїдний", 3);
            tiger.ShowInfo();
            Console.WriteLine();
            Console.ReadKey();

            crocodile.ShowInfo();
            Console.WriteLine();
            Console.ReadKey();

            kangaroo.ShowInfo();
            Console.WriteLine();
            Console.ReadKey();

            tiger.ShowInfo();
            Console.WriteLine($"Хеш-код тигра: {tiger.GetHashCode()}");
            Console.WriteLine();

            crocodile.ShowInfo();
            Console.WriteLine($"Хеш-код крокодила: {crocodile.GetHashCode()}");
            Console.WriteLine();

            kangaroo.ShowInfo();
            Console.WriteLine($"Хеш-код кенгуру: {kangaroo.GetHashCode()}");
            Console.WriteLine();
            //3
            List<Figure> figures = new List<Figure>
                {
                new Rectangle(5, 10),
                new Circle(7),
                new RightTriangle(3, 4),
                new Trapezoid(3, 5, 4)
                };
            foreach (var figure in figures)
            {
                Console.WriteLine($"Площа фігури: {figure.CalculateArea()}, HashCode: {figure.GetHashCode()}");
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
