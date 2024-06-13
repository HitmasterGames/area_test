using System;

namespace lr3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, Rad, A, H, B, C, D;
            int variant;

            Console.WriteLine("1. Прямоугольник");
            Console.WriteLine("2. Круг");
            Console.WriteLine("3. Треугольник");
            Console.WriteLine("4. Трапеция");
            //Console.WriteLine("5. Сектор");

            string temp = Console.ReadLine();
            try
            {
                variant = Convert.ToInt32(temp);    // преобразование в число
            }
            catch { variant = 0; }

            try
            {
                switch (variant)
                {
                    case 1:
                        Console.Write("Сторона А = ");
                        temp = Console.ReadLine();
                        a = Convert.ToDouble(temp);
                        Console.Write("Сторона B = ");
                        temp = Console.ReadLine();
                        b = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь прямоугольника = " + a * b);
                        Console.WriteLine("Периметр прямоугольника = " + (a + b)*2);
                        break;

                    case 2:
                        Console.Write("Радиус R = ");
                        temp = Console.ReadLine();
                        Rad = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь круга = " + 4 * Math.Atan(1.0) * Math.Pow(Rad, 2.0));
                        Console.WriteLine("Периметр круга = " + (Math.PI*Rad) * 2);
                        break;
                    case 3:
                        Console.Write("Основание A = ");
                        temp = Console.ReadLine();
                        A = Convert.ToDouble(temp);
                        Console.Write("Сторона B = ");
                        temp = Console.ReadLine();
                        B = Convert.ToDouble(temp);
                        Console.Write("Сторона C = ");
                        temp = Console.ReadLine();
                        C = Convert.ToDouble(temp);
                        Console.Write("Высота H = ");
                        temp = Console.ReadLine();
                        H = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь треугольника = "+(A*H)/2);
                        Console.WriteLine("Периметр треугольника = " + (A + B + C));
                        Console.ReadKey(); 
                        break;
                    case 4:
                        Console.Write("Основание A = ");
                        temp = Console.ReadLine();
                        A = Convert.ToDouble(temp);
                        Console.Write("Основание B = ");
                        temp = Console.ReadLine();
                        B = Convert.ToDouble(temp);
                        Console.Write("Сторона C = ");
                        temp = Console.ReadLine();
                        C = Convert.ToDouble(temp);
                        Console.Write("Сторона D = ");
                        temp = Console.ReadLine();
                        D = Convert.ToDouble(temp);
                        Console.Write("Высота H = ");
                        temp = Console.ReadLine();
                        H = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь трапеции = " + (A + B) * H / 2);
                        Console.WriteLine("Периметр трапеции = " + (A + B + C + D));
                        Console.ReadKey();
                        break;



                    default: Console.WriteLine("Выбор неверен "); break;
                }
            }
            catch { Console.WriteLine("Ошибка при вводе числа"); }
        }
    }
}
