using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_3_Asset_Tracking
{
    class Computer : Asset
    {
        public Computer(Price price, DateTime date, string brand, string model, string office) : base(price, date, brand, model, office)
        {

        }

        public override string AssetType { get => "Computer";}
    }
}
