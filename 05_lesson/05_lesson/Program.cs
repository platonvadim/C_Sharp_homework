/*
Author: Vadim Platon 


2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.

 */
using System.Text;
using static _05_lesson.Message;
namespace _05_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Исходный текст \n{Message.text}");
            Console.WriteLine("\n");
            Console.WriteLine($"Вывод слов содержащих не более 5 символов:");
            Message.PrintNLenghtWords(5);
            Console.WriteLine("\n");
            Console.WriteLine($"Удаляем все слова, которые заканчиваются на a:");
            Message.DeleteAllWordByEndChar('a');
            Console.WriteLine("\n");
            Console.WriteLine($"Самое длинное слово: {Message.FindLongesthWord()}");
            
            Console.WriteLine("\n");
            Console.WriteLine($"Список самых длинных слов: {Message.GetLongWordsString()}");
            

        }
    }

}