/*
 * Author: Vadim Platon
 
 Урок 6. Делегаты, файлы, коллекции
1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

 */

using System;
using System.Text;
// Описываем делегат. В делегате описывается сигнатура методов, на
// которые он сможет ссылаться в дальнейшем (хранить в себе)
public delegate double Fun(double a, double x);
class Program
{
    // Создаем метод, который принимает делегат
    // На практике этот метод сможет принимать любой метод
    // с такой же сигнатурой, как у делегата
    public static void Table(Fun F, double a, double x, double b)
    {
        Console.WriteLine("----- A ----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }
    // Создаем метод для передачи его в качестве параметра в Table
    public static double MyFunc(double a, double x)
    {
        return a * x * x;
    }

    public static double MySin(double a, double x)
    {
        return a * Math.Sin(x);
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Создаем новый делегат и передаем ссылку на него в метод Table
        Console.WriteLine("Таблица функции a*x^2:");
        // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
        Table(new Fun(MyFunc), -1.5, -2, 2);

        Console.WriteLine("Таблица функции a*sin(x):");
        Table(new Fun(MyFunc), 3, -2, 2);

        Console.ReadKey();
    }
}
