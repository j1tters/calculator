class Program

{
    static void Main(string[] args)

    {
        Console.WriteLine("1. Сложить 2 числа");

        Console.WriteLine("2. Вычесть первое из второго");

        Console.WriteLine("3. Перемножить два числа");

        Console.WriteLine("4. Разделить первое на второе");

        Console.WriteLine("5. Возвести в степень N первое число");

        Console.WriteLine("6. Найти квадратный корень из числа");

        Console.WriteLine("7. Найти 1 процент от числа");

        Console.WriteLine("8. Найти факториал из числа");

        Console.WriteLine("9. Выйти из программы");

        bool resume;

        do
        {
            Console.WriteLine("Выберите какую операцию вы хотите выполнить: ");
            int choose;

            do
            {
                choose = Convert.ToInt32(Console.ReadLine());
            }
            while (choose >= 9 && choose < 1);
            Console.WriteLine("Введите 1 число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int value;
            int result;
            switch (choose)
            {

                case 1:
                    Console.WriteLine(a + b);
                    break;

                case 2:
                    Console.WriteLine(a - b);
                    break;

                case 3:
                    Console.WriteLine(a * b);
                    break;

                case 4:
                    Console.WriteLine(a / b);
                    break;

                case 5:
                    Console.WriteLine(Math.Pow(a, b));
                    break;

                case 6:
                    Console.WriteLine(Math.Sqrt(a));
                    break;

                case 7:
                    Console.WriteLine(a / 100);
                    break;

                case 8:
                    Console.WriteLine("Введите число, факториал которого хотите вычислить: ");
                    value = Convert.ToInt32(Console.ReadLine());
                    result = 1;
                    for (int f = 1; f <= value; f++)

                    {
                        result = result * f;
                        Console.WriteLine(result);
                    }

                    break;

                case 9:
                    Environment.Exit(0);
                    break;

            }
            Console.WriteLine("Введите true для продолжения: ");
            resume = Convert.ToBoolean(Console.ReadLine());
        } while (resume);


    }
}
