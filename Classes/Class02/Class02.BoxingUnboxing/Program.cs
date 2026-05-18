namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number1 = 9000;
            object objNumber1 = number1;

            object objNumber2 = 1000;
            int number2 = (int)objNumber2;
        }
    }
}
