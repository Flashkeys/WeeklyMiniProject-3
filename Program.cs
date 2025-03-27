using Checkpoint_3_Asset_Tracking;
using System.Diagnostics;
using WeeklyMiniProject3;

LiveCurrency.FetchRates();
string usa = "USA";
string sweden = "Sweden";
string germany = "Germany";
AssetList assetList = new AssetList();

assetList.AddAsset(new Smartphone(new Price(200, Currency.USD), DateTime.Now.AddMonths(-36 + 4), "Motorola", "X3", usa));
assetList.AddAsset(new Smartphone(new Price(400, Currency.USD), DateTime.Now.AddMonths(-36 + 5), "Motorola", "X3", usa));
assetList.AddAsset(new Smartphone(new Price(400, Currency.USD), DateTime.Now.AddMonths(-36 + 10), "Motorola", "X2", usa));
assetList.AddAsset(new Smartphone(new Price(4500, Currency.SEK), DateTime.Now.AddMonths(-36 + 6), "Samsung", "Galaxy 10", sweden));
assetList.AddAsset(new Smartphone(new Price(4500, Currency.SEK), DateTime.Now.AddMonths(-36 + 7), "Samsung", "Galaxy 10", sweden));
assetList.AddAsset(new Smartphone(new Price(3000, Currency.SEK), DateTime.Now.AddMonths(-36 + 4), "Sony", "XPeria 7", sweden));
assetList.AddAsset(new Smartphone(new Price(3000, Currency.SEK), DateTime.Now.AddMonths(-36 + 5), "Sony", "XPeria 7", sweden));
assetList.AddAsset(new Smartphone(new Price(220, Currency.EUR), DateTime.Now.AddMonths(-36 + 12), "Siemens", "Brick", germany));
assetList.AddAsset(new Computer(new Price(100, Currency.USD), DateTime.Now.AddMonths(-37), "Dell", "Desktop 900", usa));
assetList.AddAsset(new Computer(new Price(300, Currency.USD), DateTime.Now.AddMonths(-36 + 1), "Lenovo", "X100", usa));
assetList.AddAsset(new Computer(new Price(300, Currency.USD), DateTime.Now.AddMonths(-36 + 4), "Lenovo", "X200", usa));
assetList.AddAsset(new Computer(new Price(500, Currency.USD), DateTime.Now.AddMonths(-36 + 9), "Lenovo", "X300", usa));
assetList.AddAsset(new Computer(new Price(1500, Currency.SEK), DateTime.Now.AddMonths(-36 + 7), "Dell", "Optiplex 100", sweden));
assetList.AddAsset(new Computer(new Price(100, Currency.USD), DateTime.Now.AddMonths(-38), "Dell", "Desktop 900", usa));
assetList.AddAsset(new Computer(new Price(1400, Currency.SEK), DateTime.Now.AddMonths(-36 + 8), "Dell", "Optiplex 200", sweden));
assetList.AddAsset(new Computer(new Price(1300, Currency.SEK), DateTime.Now.AddMonths(-36 + 9), "Dell", "Optiplex 300", sweden));
assetList.AddAsset(new Computer(new Price(1600, Currency.EUR), DateTime.Now.AddMonths(-36 + 14), "Asus", "ROG 600", germany));
assetList.AddAsset(new Computer(new Price(1200, Currency.EUR), DateTime.Now.AddMonths(-36 + 4), "Asus", "ROG 500", germany));
assetList.AddAsset(new Computer(new Price(1200, Currency.EUR), DateTime.Now.AddMonths(-36 + 3), "Asus", "ROG 500", germany));
assetList.AddAsset(new Computer(new Price(1300, Currency.EUR), DateTime.Now.AddMonths(-36 + 2), "Asus", "ROG 500", germany));


Console.WriteLine("To show list - enter:'P'   To quit - enter: 'Q'");

while (true)
{
    string checkInput = Console.ReadLine().Trim();

    // Check if the user wants to quit the program
    if (checkInput.ToUpper() == "Q")
    {
        break;
    }
    // Check if the user wants to print the list
    if (checkInput.ToUpper() == "P")
    {
        assetList.PrintAssets();
        continue;
    }
    
}
class AssetList
{
    // List of assets
    public AssetList()
    {
        Assets = new List<Asset>();
    }
    public List<Asset> Assets { get; set; }

    // Add an asset to the list and sort it by office and purchase date
    public void AddAsset(Asset product)
    {
        Assets.Add(product);
        Assets = Assets.OrderBy(l => l.Office).ThenByDescending(d => d.PurchasedDate).ToList();
    }

    // Print the list of assets
    public void PrintAssets()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Office".PadRight(20) + "Asset".PadRight(20) + "Brand".PadRight(20) + "Model".PadRight(20) +
            "Price (USD)".PadRight(20) + "Price (Local)".PadRight(20) + "Purchase Date".PadRight(20));
        Console.ResetColor();

        // Print each asset
        foreach (var assets in Assets)
        {
            Console.ResetColor();
            assets.Print();
        }
    }
}