using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var START_OF_396_BRACKET = 470700.0;
            var START_OF_35_BRACKET = 416700.0;
            var START_OF_33_BRACKET = 233350.0;
            var START_OF_28_BRACKET = 153100.0;
            var START_OF_25_BRACKET = 75900.0;
            var START_OF_15_BRACKET = 18650.0;

            var taxesAt396 = 0.0;
            var taxesAt35 = 0.0;
            var taxesAt33 = 0.0;
            var taxesAt28 = 0.0;
            var taxesAt25 = 0.0;
            var taxesAt15 = 0.0;
            var taxesAt10 = 0.0;

            var grossIncome = 0.0;
            var income = 0.0;
            do
            {
                Console.WriteLine("Please enter your income or 0 to stop:");
                income = Double.Parse(Console.ReadLine());
                grossIncome += income;
            } while (income != 0);

            Console.WriteLine("Do you want to take the standard deduction? (y/n)");
            var standardDeduction = Console.ReadLine();

            var totalDeductions = 0.0;
            var deduction = 0.0;

            if ( standardDeduction == "y")
            {
                totalDeductions = 12700;
            }
            else
            {
                do
                {
                    Console.WriteLine("Please enter a deduction or 0 to stop:");
                    deduction = Double.Parse(Console.ReadLine());
                    totalDeductions += deduction;
                } while (deduction != 0);
            }

            var adjustedGrossIncome = grossIncome - totalDeductions;

            var incomeToBeTaxed = adjustedGrossIncome;

            if ( incomeToBeTaxed > START_OF_396_BRACKET )
            {
                taxesAt396 = ( incomeToBeTaxed - START_OF_396_BRACKET ) * .396;
                incomeToBeTaxed = START_OF_396_BRACKET;
            }

            if ( incomeToBeTaxed > START_OF_35_BRACKET )
            {
                taxesAt35 = (incomeToBeTaxed - START_OF_35_BRACKET) * .35;
                incomeToBeTaxed = START_OF_35_BRACKET;
            }

            if (incomeToBeTaxed > START_OF_33_BRACKET)
            {
                taxesAt33 = (incomeToBeTaxed - START_OF_33_BRACKET) * .33;
                incomeToBeTaxed = START_OF_33_BRACKET;
            }

            if (incomeToBeTaxed > START_OF_28_BRACKET)
            {
                taxesAt28 = (incomeToBeTaxed - START_OF_28_BRACKET) * .28;
                incomeToBeTaxed = START_OF_28_BRACKET;
            }

            if (incomeToBeTaxed > START_OF_25_BRACKET)
            {
                taxesAt25 = (incomeToBeTaxed - START_OF_25_BRACKET) * .25;
                incomeToBeTaxed = START_OF_25_BRACKET;
            }

            if (incomeToBeTaxed > START_OF_15_BRACKET)
            {
                taxesAt15 = (incomeToBeTaxed - START_OF_15_BRACKET) * .15;
                incomeToBeTaxed = START_OF_15_BRACKET;
            }

            if (incomeToBeTaxed > 0)
            {
                taxesAt10 = incomeToBeTaxed  * .10;
                incomeToBeTaxed = 0;
            }


            Console.WriteLine($"Taxes owed at 10% ${taxesAt10}");
            Console.WriteLine($"Taxes owed at 15% ${taxesAt15}");
            Console.WriteLine($"Taxes owed at 25% ${taxesAt25}");
            Console.WriteLine($"Taxes owed at 28% ${taxesAt28}");
            Console.WriteLine($"Taxes owed at 33% ${taxesAt33}");
            Console.WriteLine($"Taxes owed at 35% ${taxesAt35}");
            Console.WriteLine($"Taxes owed at 39.6% ${taxesAt396}");

            var totalTaxesPaided = taxesAt10 + taxesAt15 + taxesAt25 + taxesAt28
                + taxesAt33 + taxesAt35 + taxesAt396;

            Console.WriteLine($"Total taxes owed: ${totalTaxesPaided}");

            if (grossIncome > 0)
            {
                Console.WriteLine($"Total taxes as % of gross income: {totalTaxesPaided / grossIncome * 100}%");
                Console.WriteLine($"Total taxes as % of AGI: {totalTaxesPaided / adjustedGrossIncome * 100 }%");
            }

            Console.ReadLine();
        }
    }
}
