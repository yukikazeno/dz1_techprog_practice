using System;
using System.Threading;


namespace dz_from_Latypova
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
            Console.WriteLine("Задание 1:");
            Console.WriteLine($"число е: {Math.Round(Math.E, 1)}");
            TaskEnd();

            Console.WriteLine("Задание 2: ");
            Console.WriteLine("50");
            Console.WriteLine("10");
            TaskEnd();


            Console.WriteLine("Задание 3: ");
            Random n = new Random();
            for (int i = 0; i < 4; i++) { Console.WriteLine(n.Next(1, 250)); }
            TaskEnd();


            Console.WriteLine("Задание 4: ");
            Console.Write("Введите ваше число (при наличии у числа дробной части, введите ее через запятую): ");
            double chislo4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат: {chislo4 + 10.0}");
            TaskEnd();


            Console.WriteLine("Задание 5: ");
            Console.Write("Введите угол x в радианах (при наличии у числа дробной части, введите ее через запятую): ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Cos(x);
            Console.WriteLine($"Результат: y = cos({x}) = {y}");
            TaskEnd();


            Console.WriteLine("Задание 6: ");
            Console.WriteLine("Последовательно введите большее основание трапеции, меньшее основание и высоту (при наличии у числа дробной части, введите ее через запятую): ");
            double lonk = Convert.ToDouble(Console.ReadLine());
            double sholt = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            double side = Math.Sqrt(Math.Pow(height, 2) + Math.Pow((lonk - sholt), 2));
            Console.WriteLine($"Периметр трапеции равен {side * 2 + lonk + sholt}");
            TaskEnd();


            Console.WriteLine("Задание 7: ");
            Console.Write("Мир Труд Май");
            Console.WriteLine();
            Console.WriteLine("Мир");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Труд");
            Console.SetCursorPosition(11, 4);
            Console.WriteLine("Май");
            TaskEnd();


            Console.WriteLine("Задание 8:");
            Console.Write("введите 1-е число (при наличии у числа дробной части, введите ее через запятую): ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите 2-е число (при наличии у числа дробной части, введите ее через запятую): ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"результат: {num2} {num1}");
            TaskEnd();


            Console.WriteLine("Задание 9: ");
            Console.Write("Введите число (при наличии у числа дробной части, введите ее через запятую): ");
            string chislo9 = Console.ReadLine();
            Console.WriteLine($"Вы ввели число {chislo9}");
            TaskEnd();


            Console.WriteLine("Задание 10: ");
            Console.Write("Последовательно введите коэффициенты квадратного уравнения вида y = ax^2 + bx + c (при наличии у числа дробной части, введите ее через запятую): ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
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
            else
            {
                Console.WriteLine("Нет корней, поскольку дискриминант меньше нуля");
            }
            TaskEnd();


            Console.WriteLine("Задание 11: ");
            Console.Write("Введите два целых числа последовательно (при наличии у числа дробной части, введите ее через запятую): ");
            double c1 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое равно {(c1 + c2) / 2}");
            Console.WriteLine($"Среднее геометрическое равно {Math.Sqrt(c1 * c2)}");
            TaskEnd();


            Console.WriteLine("Задание 12: ");
            Console.Write("Последовательно введите координаты первой точки (при наличии у числа дробной части, введите ее через запятую): x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Последовательно введите координаты второй точки (при наличии у числа дробной части, введите ее через запятую): x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Расстояние между точками равно {Math.Sqrt(Math.Pow(x1 + x2, 2) + Math.Pow(y1 + y2, 2))}");
            TaskEnd();


            Console.WriteLine("Задание 13: ");
            Console.Write("Последовательно введите числа (при наличии у числа дробной части, введите ее через запятую): a = ");
            double a13 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b13 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c13 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Вы ввели: a = {a13}, b = {b13}, c = {c13}");
            double aa = b13;
            double ba = c13;
            double ca = a13;
            double ab = c13;
            double bb = a13;
            double cb = b13;
            Console.WriteLine($"Результаты варианта а): a = {aa}, b = {ba}, c = {ca}");
            Console.WriteLine($"Результаты варианта в): a = {ab}, b = {bb}, c = {cb}");
            TaskEnd();


            Console.WriteLine("Задание 14: ");
            Console.Write("Введите количество секунд: ");
            double n14 = Convert.ToDouble(Console.ReadLine());
            double hours = Math.Floor(n14 / 3600);
            double minutes = Math.Floor((n14 / 3600 - hours) * 60);
            double sec = n14 - (hours * 3600 + minutes * 60);
            Console.WriteLine($"Результат: количество часов = {hours}, минут = {minutes}, секунд = {sec}");
            TaskEnd();


            Console.WriteLine("Задание 15: ");
            int x15 = 543;
            int y15 = 130;
            int akv = 130;
            Console.WriteLine($"Стороны прямоугольника: x = {x15}, y = {y15}; Сторона отрезаемого квадрата: a = {akv}");
            Console.WriteLine($"От прямоугольника можно отрезать {(x15 * y15) / (akv * akv)} квадратов");
            TaskEnd();


            Console.WriteLine("Задание 16: ");
            Console.Write("Введите трёхзначное число: ");
            string chis16 = Console.ReadLine();
            Console.WriteLine($"Результат: {chis16[2] + chis16.Substring(0, 2)}");
            TaskEnd();


            Console.WriteLine("Задание 17: ");
            Console.Write("Введите натуральное число, болшее чем 999: ");
            int chis17 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Ответ: а) {chis17 / 100} ");
            Console.WriteLine($"Результат б): {chis17 / 1000}");
            TaskEnd();


            Console.WriteLine("Задание 18 а): ");
            Console.Write("Введите ваше имя: ");
            string username18 = Console.ReadLine();
            Console.WriteLine($"{username18}");

            Console.WriteLine("Задание 18 б): ");
            Console.Write("Введите ваше имя: ");
            string Username18 = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {Username18}!");
            TaskEnd();


            Console.WriteLine("Задание 19: ");
            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string username19 = Console.ReadLine();
            Console.WriteLine($"Привет, {username19}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            Thread.Sleep(5000);
            Random rnd = new Random();
            Console.BackgroundColor = (ConsoleColor)rnd.Next(2, 16);
            Console.Clear();
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            TaskEnd();


            Console.WriteLine("Задание 20 а): ");
            Random lpi = new Random();
            string code = "";
            for (int i = 0; i < 12; i++) { code = code + Convert.ToString(lpi.Next(0, 10)); }
            int nechet = 0;
            for (int i = 0; i < 12;)
            {
                nechet = nechet + int.Parse(Convert.ToString(code[i]));
                i = i + 2;
            }
            int chet = 0;
            for (int poi = 1; poi < 12;)
            {
                chet = chet + int.Parse(Convert.ToString(code[poi]));
                poi = poi + 2;
            }
            int nums = nechet + chet * 3;
            Console.WriteLine($"Цифры штрихкода: {code}");
            Console.WriteLine($"Контрольная цифра: {Math.Ceiling(nums * 1.0 / 10) * 10 - nums}");
            TaskEnd();


            Console.WriteLine("Задание 20 б): ");
            Console.Write("Введите значение штрихкода (12-ти значное число)");
            string code21 = Console.ReadLine();
            int nechet21 = 0;
            for (int i = 0; i < 12;)
            {
                nechet21 = nechet21 + int.Parse(Convert.ToString(code21[i]));
                i = i + 2;
            }
            int chet21 = 0;
            for (int poi = 1; poi < 12;)
            {
                chet21 = chet21 + int.Parse(Convert.ToString(code21[poi]));
                poi = poi + 2;
            }
            int nums21 = nechet21 + chet21 * 3;
            Console.WriteLine($"Контрольная цифра: {Math.Ceiling(nums21 * 1.0 / 10) * 10 - nums21}");
            TaskEnd();
        }
    }
}
