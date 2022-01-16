
namespace MortgageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool endApp = false;

            Console.WriteLine("Mortgage Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {

                string numInput1 = "";
                string numInput2 = "";
                string numInput3 = "";
                string numInput4 = "";

                double result = 0;

                Console.Write("Type the principal, and then press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }

                Console.Write("Type the annual interest, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }

                Console.Write("Type the total years, and then press Enter: ");
                numInput3 = Console.ReadLine();

                double cleanNum3 = 0;
                while (!double.TryParse(numInput3, out cleanNum3))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput3 = Console.ReadLine();
                }

                Console.Write("Type the payments per year, and then press Enter: ");
                numInput4 = Console.ReadLine();

                double cleanNum4 = 0;
                while (!double.TryParse(numInput4, out cleanNum4))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput4 = Console.ReadLine();
                }

                try
                {
                    result = MortgageCalculator.calculatePeriodPayment(cleanNum1, cleanNum2, cleanNum3, cleanNum4);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;

        }
    }
}
