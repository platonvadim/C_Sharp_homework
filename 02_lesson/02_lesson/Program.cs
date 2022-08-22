/*
 * Lesson 2
 * Author: Vadim PLATON
 */

using System.Text;


namespace Lesson_02
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            /// <summary>
            ///  1. Написать метод, возвращающий минимальное из трёх чисел.
            /// </summary>
            #region Task1
            Console.WriteLine("Task 1.");
            Console.WriteLine("Введите 3 числа: ");
            
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("z = ");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine($"Минимальное значение: {FindMinValue(x, y, z)}");
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
            #endregion

            /// <summary>
            ///  2. Написать метод подсчета количества цифр числа.
            /// </summary>
            #region Task2
            Console.WriteLine("Task 2.");
            Console.WriteLine("Введите целое число: ");

            Console.Write("x = ");
            string num = Console.ReadLine();


            Console.WriteLine($"Колличесвто цифр в числе: {calculateDigitsOfNum(num)}");
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
            #endregion

            /// <summary>
            ///  3. С клавиатуры вводятся числа, пока не будет введен 0. 
            ///  Подсчитать сумму всех нечетных положительных чисел.
            /// </summary>
            #region Task3
            Console.WriteLine("Task 3.");
            Console.WriteLine("Вводите целые число (0 - для подсчета суммы всех нечетных): ");
            int n;
            int ans = 0;
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n != 0 && n % 2 != 0)
                {
                    ans += n;
                }
            } while (n != 0);



            Console.WriteLine($"Сумма нечетных чисел: {ans}");
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
            #endregion


            /// <summary>
            ///  4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
            ///  На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            ///  Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
            ///  программа пропускает его дальше или не пропускает. 
            ///  С помощью цикла do while ограничить ввод пароля тремя попытками.
            /// </summary>
            #region Task4
            Console.WriteLine("Task 4.");
            Console.WriteLine("Авторизация: ");


            int attemts = 3;
            bool result;
            do
            {
                Console.Write("Логин: ");
                string login = Console.ReadLine();

                Console.Write("Пароль: ");
                string password = Console.ReadLine();

                result = checkCredentials(login, password);
                if (result)
                {
                    Console.WriteLine("*Вы успешно авторизованы.");
                    break;
                }
                else
                {
                    Console.WriteLine("Логин или пароль неверный. Попробуйте еще раз.");
                    attemts--;
                }

            } while (attemts != 0);

            if(!result)
            {
                Console.WriteLine("Вы превысили колличество попыток для авторизации.");
            }

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
            #endregion


            /// <summary>
            ///  5.
            /// а) Написать программу, которая запрашивает массу и рост человека, 
            /// вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, 
            /// набрать вес или всё в норме.
            /// </summary>
            #region Task5
            Console.WriteLine("Task 5.");
            Console.Write("Введите массу тела (kg, ex: 85,5): ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Введите рост (meters, ex: 1,87): ");
            double height = double.Parse(Console.ReadLine());


            switch(checkIMT(weight, height))
            {
                case 1: Console.WriteLine("Ваш Индекс Массы Тела НИЖЕ НОРМЫ. Нужно поправиться!"); break;
                case 2: Console.WriteLine("Ваш Индекс Массы Тела в НОРМЕ. Так держать!"); break;
                case 3: Console.WriteLine("Ваш Индекс Массы Тела ВЫШЕ НОРМЫ. Нужно худеть!"); break;
            }
           
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
            #endregion
        }
        private static double FindMinValue(double x, double y, double z)
        {
            double min = x;
            if (min > y)
            {
                min = y;
            }
            if (min > z)
            {
                min = z;
            }

            return min;
        }

        private static int calculateDigitsOfNum(string num)
        {
            int digits = 0;

            digits = num.Length;

            return digits;
        }

        private static bool checkCredentials(string login, string password)
        {
            bool result = false;

            if(login == "root" && password == "GeekBrains")
            {
                result = true;
            }

            return result;
        }

        private static int checkIMT(double weight, double height)
        {
            int result;

            double IMT = weight / (height * height);

            if (IMT < 18.5)
            {
                result = 1; // Less than normal
            }
            else if (IMT >= 18.5 && IMT < 25)
            {
                result = 2; // Nomral
            }
            else
            {
                result = 3; // More than normal
            }

            return result;
        }
    }

    
}
