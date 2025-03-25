using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyMiniProject3;

namespace Checkpoint_3_Asset_Tracking
{
    // Abstract class that represents an asset
    abstract class Asset
    {
        public Asset(Price price, DateTime date, string brand, string model, string office)
        {
            LocalPrice = price;
            PurchasedDate = date;
            Brand = brand;
            Model = model;
            Office = office;
        }
        public Price LocalPrice { get; protected set; }
        public DateTime PurchasedDate { get; protected set; }
        public string Brand { get; protected set; }
        public string Model { get; protected set; }
        public string Office { get; protected set; }
        public abstract string AssetType { get; }

        // Print the asset information
        public void Print()
        {
            double priceInEuro = LiveCurrency.Convert(LocalPrice.Value, Enum.GetName(LocalPrice.LocalCurrency), "EUR");
            double priceInUSD = LiveCurrency.Convert(priceInEuro, "EUR", "USD");

            // If the asset was purchased more than 3.5 years ago, the color is red
            if (PurchasedDate <= DateTime.Now.AddYears(-3).AddMonths(+3))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            // If the asset was purchased between 3 and 3.5 years ago, the color is yellow
            else if (PurchasedDate <= DateTime.Now.AddYears(-3).AddMonths(+6))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.WriteLine(Office.PadRight(20) +
                AssetType.PadRight(20) +
                Brand.PadRight(20) +
                Model.PadRight(20) +
                new Price(priceInUSD, Currency.USD).ToString().PadRight(20) +
                LocalPrice.ToString().PadRight(20) +
                PurchasedDate
                );
        }
    }
}
