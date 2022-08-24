/*
 * Lesson 3
 * Author: Vadim PLATON
 * 
 * Урок 3. Методы. От структур к объектам. Исключения
1.
а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.

2.
а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
 */

using System.Text;

namespace Lesson03
{
    class Complex
    {
        #region Public Methods

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public Complex Plus(Complex complex)
        {
            Complex c = new Complex();
            c.Re = _re + complex.Re;
            c._im = _im + complex._im;
            return c;
        }


        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат вычитания комплексных чисел</returns>
        public Complex Minus(Complex complex)
        {
            Complex c = new Complex();
            c.Re = _re - complex.Re;
            c._im = _im - complex._im;
            return c;
        }

        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат умножения комплексных чисел</returns>
        public Complex Mul(Complex complex)
        {
            Complex c = new Complex();

            c.Re = _re * complex.Im + _im * complex.Re;
            c._im = _re * complex.Re + _im * complex.Im;
            return c;
        }

        /// <summary>
        /// Перегрузка оператора +, сложение комплексных чисел
        /// </summary>
        /// <param name="complex1">Комплексное число</param>
        /// <param name="complex2">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public static Complex operator +(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re + complex2.Re, Im = complex1.Im + complex2.Im };
        }

        /// <summary>
        /// Перегрузка оператора -, вычитание комплексных чисел
        /// </summary>
        /// <param name="complex1">Комплексное число</param>
        /// <param name="complex2">Комплексное число</param>
        /// <returns>Результат вычитания комплексных чисел</returns>
        public static Complex operator -(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re - complex2.Re, Im = complex1.Im - complex2.Im };
        }

        /// <summary>
        /// Перегрузка оператора *, сложение комплексных чисел
        /// </summary>
        /// <param name="complex1">Комплексное число</param>
        /// <param name="complex2">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public static Complex operator *(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re * complex2.Im + complex1.Im * complex2.Re,
                                 Im = complex1.Re * complex2.Re + complex1.Im * complex2.Im };
        }

        public override string ToString()
        {
            return $"{_re} {_im}i";
        }

        #endregion

        #region Constructors

        public Complex() { }

        public Complex(double re, double im)
        {
            _re = re;
            this._im = im;
        }

        #endregion

        #region Fields

        private double _re;
        private double _im;

        #endregion

        #region Properties

        public double Re
        {
            get { return _re; }
            set { _re = value; }
        }

        public double Im
        {
            get { return _im; }
            set { _im = value; }
        }

        #endregion
    }

    class Program
    {
        #region Task2
        static void SumOfOddPossitiveNumbers()
        {
            Console.WriteLine("Task 2.");
            Console.WriteLine("Вводите целые числа (0 - для подсчета суммы всех нечетных положительных)");
            int n;
            int ans = 0;
            string s;
            string allGoodNumbers = "Числа: ";
            do
            {
                s = Console.ReadLine();
                if(int.TryParse(s, out n))
                {
                    if (n > 0 && n % 2 != 0)
                    {
                        allGoodNumbers += $" {n}";
                        ans += n;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное число. Попробуйте еще раз.");
                    n = 10; // Вводим правильное четное число, чтобы цикл не завершился.
                }
           
            } while (n != 0);


            
            Console.WriteLine($"Сумма нечетных положительных чисел: {ans}");
            Console.WriteLine(allGoodNumbers);
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
        }
        #endregion

        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

           
            Console.WriteLine($"Работа с комплексными числами");
            Console.Write("Введите 1 число, реальную часть. Re=");
            int re1 = int.Parse(Console.ReadLine());
            Console.Write("Введите 1 число, мнимую часть. Im=");
            int im1 = int.Parse(Console.ReadLine());
            Console.Write("Введите 2 число, реальную часть. Re=");
            int re2 = int.Parse(Console.ReadLine());
            Console.Write("Введите 2 число, мнимую часть. Im=");
            int im2 = int.Parse(Console.ReadLine());

            Complex complex1 = new Complex(re1, im1);
            Complex complex2 = new Complex(re2, im2);
            int menuItem;
            do
            {
                Console.WriteLine("===Меню===");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Сумма нечетных положительных чисел");
                Console.WriteLine("0. Выход");

                Console.Write("\nВведите пункт меню: ");
                menuItem = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nРабота с комплексными числами {complex1} и {complex2}");
                switch (menuItem)
                {
                    case 0:
                        Console.WriteLine("Выход из программы..");
                        break;
                    case 1:

                        Console.WriteLine($"Результат сложения комплексных чисел {complex1 + complex2}");
                        break;
                    case 2:
                        Console.WriteLine($"Результат вычитания комплексных чисел {complex1 - complex2}");
                        break;
                    case 3:
                        Console.WriteLine($"Результат умножения комплексных чисел {complex1 * complex2}");
                        break;
                    case 4:
                        SumOfOddPossitiveNumbers();
                        break;
                    default:
                        Console.WriteLine("Вы ввели несуществующий пункт меню.");
                        break;
                }




                Console.ReadLine();
            }
            while (menuItem != 0);
        }
    }
}
