/*
 * Lesson 4
 * Author: Vadim PLATON
 * 
 * Урок 4. Массивы. Текстовые файлы
1.
а) Дописать класс для работы с одномерным массивом. 
Реализовать конструктор, создающий массив определенного размера и 
заполняющий массив числами от начального значения с заданным шагом. 

Создать 
свойство Sum, которое возвращает сумму элементов массива, 
метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений), 
метод Multi, умножающий каждый элемент массива на определённое число,
свойство MaxCount, возвращающее количество максимальных элементов.

б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки

2. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
Создайте структуру Account, содержащую Login и Password.*/


using _04_lesson;
using System.Text;

namespace lesson_04
{

    class Sample02
    {
        struct Account
        {
            public string Login;
            public string Password;

            public static Account[] loadCredentialFromFile(string filename)
            {
                StreamReader sr = new StreamReader(filename);
                Account[] Account = new Account[100];
                string line;
                int i = 0;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    Account[i].Login = line.Split(':')[0];
                    Account[i].Password = line.Split(':')[1];
                    i++;
                }
                Account[] Acc = new Account[i];
                Array.Copy(Account, Acc, i);
                sr.Close();
                return Acc;
            }

        }
        

        static void Main(string[] args)
        {
            #region Task1
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("*Пример работы библиотека MyArray.");
            string dir = AppDomain.CurrentDomain.BaseDirectory + "MyArray.txt";
            Console.WriteLine($"Чтение массива из файла {dir}");
            MyArray myArray;
            try
            {
                myArray = new MyArray(dir);
                myArray.PrintArray();
            }
            catch (Exception e)
            {

                Console.WriteLine($"Ошибка {e}.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Метод Inverse: ");
            MyArray Inverted = myArray.Inverse();
            Inverted.PrintArray();

            Console.WriteLine("Метод Multi:");
            myArray.Multi(2);
            myArray.PrintArray();

            Console.WriteLine($"Свойство Sum: {myArray.Sum}");
            Console.WriteLine($"Свойство MaxCount: {myArray.MaxCount}");

            Console.WriteLine("*Констутрок, который создаст 5 чисел от 1 с шагом в 2:");
            myArray = new MyArray(5, 1, 2);
            myArray.PrintArray();


            Console.ReadKey();
            #endregion
           
            
            Console.WriteLine("\n\n\nTask 2.");
            #region Task2
            dir = AppDomain.CurrentDomain.BaseDirectory + "database.txt";
            Console.WriteLine("Загрузка логинов и паролей из файла");
            Account[] database = Account.loadCredentialFromFile(dir);
            Console.WriteLine($"Загружено {database.Length}");

            foreach(Account account in database)
            {
                Console.WriteLine($"Проверка {account.Login}:{account.Password}");
                if (account.Password == "GeekBrains" && account.Login == "root")
                {
                    Console.WriteLine("*Логин и пароль подошли!");
                    Console.WriteLine("*Вы авторизовались!");
                    break;
                }
                else
                {
                    Console.WriteLine("Логин или пароль неверный!");
                }
                Console.WriteLine();
            }
            #endregion
        }


    }
}
