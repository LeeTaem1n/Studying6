using System;
namespace CalculateInterest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Prompt for the principal amount
            Console.Write("Input amount: ");
            string principalInput = Console.ReadLine();
            decimal principal = Convert.ToDecimal(principalInput);

            // Validate the principal input
            if (principal < 0)
            {
                Console.WriteLine("Input amount can`t be negativ. Was set value = 0.");
                principal = 0;
            }
            else
            {
                // Prompt for the interest rate
                Console.Write("Inpur your interest rate : ");
                string interestInput = Console.ReadLine();
                decimal interest = Convert.ToDecimal(interestInput);
                // Validate the interest rate input
                if (interest < 0)
                {
                    Console.WriteLine("Interest rate can`t be negativ. Was set value = 0. ");
                    interest = 0;
                }
                else
                {
                    // Calculate the interest paid
                    decimal interestPaid;
                    interestPaid = principal * (interest / 100);
                    // Calculate the total amount
                    decimal total = principal + interestPaid;

                    // Output the results
                    Console.WriteLine(); // Blank line for spacing
                    Console.WriteLine("Input amount = " + principal);
                    Console.WriteLine("Percents = " + interest + "%");
                    Console.WriteLine();
                    Console.WriteLine("Accrued interest = " + interestPaid);
                    Console.WriteLine("Sum = " + total);
                }
            }
                // Wait for user input before closing
                Console.WriteLine("Tap <Enter> to over...");
                Console.ReadLine();
                
            
        }
    }
}