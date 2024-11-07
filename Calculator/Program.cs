//calculator
namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char c;
            Console.WriteLine("Write a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write operation: (+,-,*,/,%)");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Write b");
            b = Convert.ToDouble(Console.ReadLine());
            switch (c)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2} ", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2} ", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0} * {1} = {2} ", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("{0} / {1} = {2} ", a, b, a / b);
                    break;
                case '%':
                    Console.WriteLine("{0} % {1} = {2} ", a, b, a % b);
                    break;
            }
            Console.ReadLine(); 
            Console.WriteLine("ESHHKEREEE:))))");
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
        }

    }
}
