using System;

namespace dz_from_Tumakov
{
    internal class Program
    {
        static void TaskEnd()
        {
            Console.WriteLine("Нажмите любую клавишу. . .");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1: ");
            Console.WriteLine("Как вас зовут?");
            string usersname = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {usersname}!");
            TaskEnd();

            Console.WriteLine("Упражнение 2.2: ");
            Console.WriteLine("Последовательно введите два числа (если у числа есть дробная часть, напишите ее после запятой): ");
            double ch = double.Parse(Console.ReadLine());
            double zn = double.Parse(Console.ReadLine());
            if (zn == 0) { Console.WriteLine("Делить на ноль нельзя."); }
            else { Console.WriteLine($"{ch}/{zn} = {ch / zn}"); }
            TaskEnd();

            Console.WriteLine("Домашнее задание 2.1: ");
            Console.Write("Введите букву: ");
            string chr = Console.ReadLine();
            char bkva = chr[0];
            if (bkva == 'z' | bkva == 'я' | bkva == 'Я' | bkva == 'Z') { Console.WriteLine("Это последняя буква в алфавите."); }
            else { Console.WriteLine($"Следующая буква в алфавите это {(char)(bkva + 1)}"); }
            TaskEnd();

            Console.WriteLine("Домашнее задание 2.2: ");
            Console.WriteLine("Последовательно введите коэффициенты квадратного уравнения вида y = ax^2 + bx + c (при наличии у числа дробной части, введите ее через запятую): ");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                double x110 = (-b + Math.Sqrt(D)) / (2 * a);
                double x210 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Корни уравнения: x1 = {x110}, x2 = {x210}");
            }
            else if (D == 0)
            {
                double x10 = -b / (2 * a);
                Console.WriteLine($"Корень уравнения x = {x10}");
            }
            else { Console.WriteLine("Нет корней, поскольку дискриминант меньше нуля");}
            TaskEnd();
        }
    }
}
