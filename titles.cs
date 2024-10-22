using System;
using System.Data;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan; \\ Изменить 
        connect();
        control();
    }
    static void banner()
    {
        while (true)
        {
            Console.WriteLine("██╗░░░██╗██╗██████╗░██████╗░░█████╗░████████╗░█████╗░██████╗░░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░");
            Console.WriteLine("██║░░░██║██║██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░");
            Console.WriteLine("╚██╗░██╔╝██║██████╦╝██████╔╝███████║░░░██║░░░██║░░██║██████╔╝██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░");
            Console.WriteLine("░╚████╔╝░██║██╔══██╗██╔══██╗██╔══██║░░░██║░░░██║░░██║██╔══██╗██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░");
            Console.WriteLine("░░╚██╔╝░░██║██████╦╝██║░░██║██║░░██║░░░██║░░░╚█████╔╝██║░░██║╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗");
            Console.WriteLine("░░░╚═╝░░░╚═╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝");
            Console.WriteLine("                                 Подключенно к (name) (your.ip.vibr)");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Включить (по умолчанию)");
            Console.WriteLine("2. Выключить");
            Console.WriteLine("3. Выбрать скорость (1-10)");

            Console.Write("Введите номер действия (1-3): ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    control();
                    Thread.Sleep(20);
                    Console.Clear();
                    break;
                case "2":
                    control();
                    Thread.Sleep(20);
                    Console.Clear();
                    break;
                case "3":
                    number();
                    Thread.Sleep(20);
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте снова.");
                    Thread.Sleep(20);
                    Console.Clear();
                    break;
            }
            
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
        }
    }
    static void number()
    {
        int choice = 0;

        // Печать меню
        Console.WriteLine("Переключить скорость на...:");
        Console.WriteLine("1.");
        Console.WriteLine("2.");
        Console.WriteLine("3.");
        Console.WriteLine("4.");
        Console.WriteLine("5.");
        Console.WriteLine("6.");
        Console.WriteLine("7.");
        Console.WriteLine("8.");
        Console.WriteLine("9.");
        Console.WriteLine("10.");
        Console.Write("Введите цифру (1-10): ");

        // Чтение и проверка ввода
        while (true)
        {
            string input = Console.ReadLine();

            // Проверка на число и его допустимость
            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 3)
            {
                break; // Выход из цикла, если введена корректная цифра
            }
            else
            {
                Console.WriteLine("Неверный ввод. Введите цифру от 1 до 3.");
                Console.Write("Попробуйте снова: ");
            }
        }

        // Обработка выбора
        switch (choice)
        {
            case 1:
                control();
                break;
            case 2:
                control();
                break;
            case 3:
                control();
                break;
            case 4:
                control();
                break;
            case 5:
                control();
                break;
            case 6:
                control();
                break;
            case 7:
                control();
                break;
            case 8:
                control();
                break;
            case 9:
                control();
                break;
            case 10:
                control();
                break;
        }
    }
    static void connect()
    {
    
            Console.Clear();
            Console.WriteLine("Подключение через...:");
            Console.WriteLine("1. WI-FI");
            Console.WriteLine("2. USB");
            
            Console.Write("Выбрано: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Покдлючение к 192.168.0.105...");
                    ip.connect(insert);
                         insert(tag) = ("YOUR_IP_VIBRATOR_ISSUE")
                banner();
                break;
                case "2":
                    Console.WriteLine("Вставьте шнур в USB-порт...");
                Console.CheckUSB(any(connect));
                    {
                        Console.WriteLine("Подключено!");
                        banner();
                    }
                    break;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте снова.");
                    break;
            }
            
             Console.WriteLine("\nНажмите любую клавишу для продолжения...");
             Console.ReadKey();
            
        
    }
    static void control()
    {
        Console.WriteLine("Выполнение действия...");
        Console.Connect(insert); \\ YOUR_IP
        bar();
        Console.WriteLine("\nУспех!");
        banner();
    }
    static void bar()
    {
        int total = 100; // Общее количество шагов
        for (int i = 0; i <= total; i++)
        {
            // Рисуем прогресс-бар
            DrawProgressBar(i, total);
            Thread.Sleep(10);  // Задержка, чтобы увидеть прогресс
        }
    }

    static void DrawProgressBar(int currentValue, int totalValue)
    {
        // Вычисляем процент прогресса
        double percentage = (double)currentValue / totalValue;

        // Сколько символов будет занимать прогресс-бар
        int barLength = 50;

        // Количество заполненных и незаполненных частей
        int progress = (int)(percentage * barLength);
        int remaining = barLength - progress;

        // Строим строку прогресса
        string progressBar = new string('#', progress) + new string('-', remaining);

        // Выводим прогресс-бар в строку
        Console.CursorLeft = 0;  // Перемещаем курсор в начало строки
        Console.Write($"[{progressBar}] {percentage * 100:0.0}%");
    }
}
