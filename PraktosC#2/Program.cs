using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Игра Угадайка");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("0. Ливаем");
            Console.Write("Цифру выбери: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PlayGuessNumber();
                    break;
                case 2:
                    PrintMultiplicationTable();
                    break;
                case 3:
                    PrintDivisors();
                    break;
                case 0:
                    Console.WriteLine("Ура, выходим...");
                    break;
                default:
                    Console.WriteLine("Иди учи цифры или попробуй еще разок.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 0);
    }

    static void PlayGuessNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        int guess;
        int attempts = 0;

        Console.WriteLine("Игра 'Угадайка'");
        Console.WriteLine("Вундервафля загадала число от 0 до 100.");
        Console.WriteLine("Рискни и угадай.");

        do
        {
            Console.Write("Введите число: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < randomNumber)
            {
                Console.WriteLine("Маловато.");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Чёт многовато.");
            }
            else
            {
                Console.WriteLine($"Капец! Ты угадал(а) число за {attempts} попыток.");
            }
        } while (guess != randomNumber);

        Console.WriteLine("Давай обратно в менюшку...");
    }

    static void PrintMultiplicationTable()
    {
        Console.WriteLine("Таблица умножения:");

        int[,] multiplicationTable = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                multiplicationTable[i, j] = (i + 1) * (j + 1);
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write("{0,4}", multiplicationTable[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Давай обратно в менюшку...");
    }

    static void PrintDivisors()
    {
        Console.WriteLine("Вывод делителей числа:");

        int number;
        do
        {
            Console.Write("Введите число (0 для выхода): ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number != 0)
            {
                Console.Write("Делители числа {0}: ", number);
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.Write("{0} ", i);
                    }
                }
                Console.WriteLine();
            }
        } while (number != 0);

        Console.WriteLine("Давай обратно в менюшку...");
    }
}