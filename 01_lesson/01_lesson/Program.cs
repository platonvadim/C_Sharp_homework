/*
 * Author: Vadim PLATON
 */

using System;

namespace Lesson_01 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
             */

            Console.WriteLine("Task #1");
            Console.Write("Enter your First Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your Last Name: ");
            string surname = Console.ReadLine();

            Console.Write("Enter your age: ");
            string inputStr = Console.ReadLine();
            int age = int.Parse(inputStr);

            Console.Write("Enter your height (meters, ex: 1,87): ");
            inputStr = Console.ReadLine();
            double height = double.Parse(inputStr);

            Console.Write("Enter your weight (kg, ex: 85,5): ");
            inputStr = Console.ReadLine();
            double weight = double.Parse(inputStr);

            /*В результате вся информация выводится в одну строчку:
             * а) используя склеивание;
             */
            Console.WriteLine(name + ' ' + surname + ' ' + age + ' ' + height + ' ' + weight);
            /*
             * б) используя форматированный вывод;
             */
            Console.WriteLine("{0} {1} {2} {3} {4}",name, surname, age, height, weight);
            /*
             * в) используя вывод со знаком $.
             */
            Console.WriteLine($"{name} {surname} {age} {height} {weight}");

            /* Task #2
             * Ввести вес и рост человека. 
             * Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
             * где m — масса тела в килограммах, h — рост в метрах.
             */
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Task #2");
            double IMT = weight/(height*height);
            Console.WriteLine(name + " your IMT is " + IMT);

            /* Task #3
             * а) Написать программу, которая подсчитывает расстояние между точками с координатами 
             * x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
             * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
             */
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Task #3");
            Console.Write("x1=");
            inputStr = Console.ReadLine();
            int x1 = int.Parse(inputStr);

            Console.Write("y1=");
            inputStr = Console.ReadLine();
            int y1 = int.Parse(inputStr);

            Console.Write("x2=");
            inputStr = Console.ReadLine();
            int x2 = int.Parse(inputStr);

            Console.Write("y2=");
            inputStr = Console.ReadLine();
            int y2 = int.Parse(inputStr);

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"r={r:F2}");

            /* Task #4
             * Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
             * а) с использованием третьей переменной;
             */
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Task #4");
            int a = 5;
            int b = 10;
            Console.WriteLine($"a={a}, b={b}");    
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"a={a}, b={b}");


            /* Task #5
             * Написать программу, которая выводит на экран ваше имя, фамилию и город проживания
             */
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Task #5");
            Console.WriteLine("Vadim PLATON, Kishinev");
        }
    }
}