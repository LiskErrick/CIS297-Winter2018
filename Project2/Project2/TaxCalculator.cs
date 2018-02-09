using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class TaxCalculator
    {
        public double TaxesAt10Percent { get; private set; }
        public double TaxesAt15Percent { get; private set; }
        public double TaxesAt25Percent { get; private set; }
        public double TaxesAt28Percent { get; private set; }
        public double TaxesAt33Percent { get; private set; }
        public double TaxesAt35Percent { get; private set; }
        public double TaxesAt396Percent { get; private set; }

        public double TotalTaxesOwed { get; private set; }
        public double TaxesAsPercentageOfGrossIncome { get; private set; }
        public double TaxesAsPercentageOfAdustedGrossIncome { get; private set; }

        private double _grossIncome;
        private double _deductions;
        private double _adjustedGrossIncome;

        public TaxCalculator(double grossIncome, double deductions)
        {
            _grossIncome = grossIncome;
            _deductions = deductions;

            _adjustedGrossIncome = grossIncome - deductions;

            var START_OF_396_BRACKET = 470700.0;
            var START_OF_35_BRACKET = 416700.0;
            var START_OF_33_BRACKET = 233350.0;
            var START_OF_28_BRACKET = 153100.0;
            var START_OF_25_BRACKET = 75900.0;
            var START_OF_15_BRACKET = 18650.0;

            var incomeToBeTaxed = _adjustedGrossIncome;

            if (incomeToBeTaxed > START_OF_396_BRACKET)
            {
                TaxesAt396Percent = (incomeToBeTaxed - START_OF_396_BRACKET) * .396;
                incomeToBeTaxed = START_OF_396_BRACKET;
            }

            if (incomeToBeTaxed > START_OF_35_BRACKET)
            {
                TaxesAt35Percent = (incomeToBeTaxed - START_OF_35_BRACKET) * .35;
                incomeToBeTaxed = START_OF_35_BRACKET;
            }

            if (incomeToBeTaxed > START_OF_33_BRACKET)
            {
                TaxesAt33Percent = (incomeToBeTaxed - START_OF_33_BRACKET) * .33;
                incomeToBeTaxed = START_OF_33_BRACKET;
            }

            if (incomeToBeTaxed > START_OF_28_BRACKET)
            {
                TaxesAt28Percent = (incomeToBeTaxed - START_OF_28_BRACKET) * .28;
                incomeToBeTaxed = START_OF_28_BRACKET;
            }

            if (incomeToBeTaxed > START_OF_25_BRACKET)
            {
                TaxesAt25Percent = (incomeToBeTaxed - START_OF_25_BRACKET) * .25;
                incomeToBeTaxed = START_OF_25_BRACKET;
            }

            if (incomeToBeTaxed > START_OF_15_BRACKET)
            {
                TaxesAt15Percent = (incomeToBeTaxed - START_OF_15_BRACKET) * .15;
                incomeToBeTaxed = START_OF_15_BRACKET;
            }

            if (incomeToBeTaxed > 0)
            {
                TaxesAt10Percent = incomeToBeTaxed * .10;
                incomeToBeTaxed = 0;
            }

            TotalTaxesOwed = TaxesAt10Percent + TaxesAt15Percent + TaxesAt25Percent
                + TaxesAt28Percent + TaxesAt33Percent + TaxesAt35Percent + TaxesAt396Percent;

            TaxesAsPercentageOfGrossIncome = TotalTaxesOwed / _grossIncome;
            TaxesAsPercentageOfAdustedGrossIncome = TotalTaxesOwed / _adjustedGrossIncome;
        }
    }
}
