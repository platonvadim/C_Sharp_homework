/*
 Author: Vadim Platon 

Урок 5. Символы, строки, регулярные выражения

1. Создать программу, которая будет проверять корректность ввода логина. 
Корректным логином будет строка от 2 до 10 символов, 
содержащая только буквы латинского алфавита или цифры, 
при этом цифра не может быть первой.
*/

using System.Text;
using System.Text.RegularExpressions;

namespace lesson_05
{
    class Program
    {
        /// <summary>Проверка правильности логина</summary>
        /// <param name="login">Логин</param>
        static bool CheckLogin(string login)
        {
            if (login.Length >= 2 && login.Length <= 10)
            {
                if (Char.IsDigit(login[0]))
                    return false;

                for (int i = 1; i < login.Length; i++)
                {
                    if (!(Char.IsDigit(login[i]) || _IsBasicLetter(login[i])))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private static bool _IsBasicLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Придумайте логин: ");
            string login = Console.ReadLine();

            while (!CheckLogin(login))
            {   
                Console.WriteLine("Неверный ввод логина. \nДолжны быть соблюдены следующие условия:"
                        + "\nдлина строки 2 до 10 символов;"
                        + "\nбуквы только латинского алфавита или цифры;"
                        + "\nцифра не может быть первой.");
                login = Console.ReadLine();
            }
            Console.WriteLine("Логин корректен!");

            Console.ReadKey();
        }
    }
} 