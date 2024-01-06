using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the current month from the system clock
        int month = DateTime.Now.Month;

        // Expression Switch-Case statements are decision control structures, similar to if-else statements.
        // Switch-Case statements are generally used when an expression needs to be evaluated against three or more conditions.
        // Although you can achieve the same with if-else blocks, Switch-Case provides a cleaner alternative.

        // Example of a simple Switch-Case statement
        switch (month)
        {
            case 10:
                Console.WriteLine("You are in the month of October!");
                break;
            default:
                Console.WriteLine("You entered an incorrect month!");
                break;
        }

        // Example of a Switch-Case statement with multiple cases falling through
        switch (month)
        {
            // If the month is October, November, or December, the following messages will be displayed.
            case 10:
            case 11:
            case 12:
                Console.WriteLine("You are in the autumn season!");
                Console.WriteLine("Take care not to catch a cold :)");
                break;
            default:
                // This block is executed if none of the specified cases match the current month.
                break;
        }
    }
}
