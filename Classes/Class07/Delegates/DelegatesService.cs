namespace Delegates
{
    public class DelegatesService
    {
        private delegate double CalculationDelegate(int n1, int n2);
        private delegate void SayDelegate(string text);

        private void SayHello(string text)
        {
            Console.WriteLine(text);
        }

        private void SayWhatever(string whatever, SayDelegate sayMethod)
        {
            sayMethod(whatever);
        }

        private double Calculate(int n1, int n2, CalculationDelegate operation)
        {
            return operation(n1, n2);
        }

        private double Product(int n1, int n2)
        {
            return n1 * n2;
        }

        public void Run()
        {
            Console.WriteLine("Hello World!");

            Func<int, int, int> subtractFunc = (n1, n2) => n1 - n2;
            Console.WriteLine(subtractFunc(10, 20));

            Action<string, ConsoleColor> printInColor = (text, color) =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            };
            printInColor("This is red text", ConsoleColor.Red);

            CalculationDelegate subtract = (n1, n2) => n1 - n2;
            Console.WriteLine(subtract(20, 5));

            SayDelegate sayHello = new SayDelegate(word => Console.WriteLine(word));
            sayHello("Hello");

            SayDelegate sayHelloAgain = new SayDelegate(SayHello);

            SayWhatever("WHATEVER!", SayHello);
            SayWhatever("WHATEVER!", sayHello);
            SayWhatever("WHATEVER!", text => Console.WriteLine(text));
            SayWhatever("WHATEVER!", text => printInColor(text, ConsoleColor.Green));

            printInColor("========== Calculator Example ==========", ConsoleColor.Magenta);

            double sumResult = Calculate(10, 20, (n1, n2) => n1 + n2);
            printInColor("The sum result is " + sumResult, ConsoleColor.Yellow);

            double subtractResult = Calculate(10, 20, subtract);
            printInColor("The subtract result is " + subtractResult, ConsoleColor.Cyan);

            double productResult = Calculate(10, 20, Product);
            printInColor("The product result is " + productResult, ConsoleColor.DarkYellow);
        }
    }
}
