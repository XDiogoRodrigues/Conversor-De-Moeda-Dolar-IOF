using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public double TotalQuoteValue()
        {
            return (QuoteValue * Value) + (QuoteValue * Value * 0.06);
        }
    }
}
