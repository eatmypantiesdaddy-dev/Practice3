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
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;

                case "0":
                    break;
            }
        }
    }
}
