using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_3_Asset_Tracking
{
    // Enum for the different currencies
    enum Currency
    {
        USD,
        SEK,
        EUR
    }
    // Class that represents the price of an asset in a specific currency
    class Price
    {
        public Price(double price, Currency currency)
        {
            Value = price;
            LocalCurrency = currency;
        }
        public double Value { get; private set; }
        public Currency LocalCurrency { get; private set; }

        // Method that converts the price to a string with the currency
        public override string ToString()
        {
            return Enum.GetName(LocalCurrency) +" " + Value.ToString("#.##");
            //return Value.ToString("#.##");
        }

    }
}
