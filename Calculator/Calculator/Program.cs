namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите пункт меню:");
            Console.WriteLine("Введите А:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите В:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("1. Выполнить сложение");
            Console.WriteLine("2. Выполнить вычитание");
            Console.WriteLine("3. Выполнить умножение");
            Console.WriteLine("4. Выполнить деление");
            Console.WriteLine("0. Выход");
            string key = Console.ReadLine();

            switch (key)
            {
                case "1":
                    Console.WriteLine($"Сложение: {A} + {B} = {A + B}");
                    break;

                case "2":
                    Console.WriteLine($"Вычитание: {A} - {B} = {A - B}");
                    break;

                case "3":
                    Console.WriteLine($"Умножение: {A} * {B} = {A * B}");
                    break;

                case "4":
                    break;

                case "0":
                    break;
            }
        }
    }
}
