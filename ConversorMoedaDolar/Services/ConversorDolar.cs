using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConversorMoedaDolar
{
    class ConversorDolar
    {
        public double Value { get; set; }
        public double QuoteValue { get; set; }

        public ConversorDolar(double valueDolar, double quoteValue)
        {
            Value = valueDolar;
            QuoteValue = quoteValue;
        }

        public void VerificationValue()
        {
            if (Value > 0 && QuoteValue > 0)
            {
                Console.WriteLine("Amount to be paid in reais: " + TotalQuoteValue().ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                throw new DomainException("Quote value and dollar amount value must be greater than 0.");
            }
                        
        }

        private double TotalQuoteValue()
        {
            return (QuoteValue * Value) + (QuoteValue * Value * 0.06);
        }
    }
}
