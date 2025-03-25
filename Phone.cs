using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_3_Asset_Tracking
{
    class Phone : Asset
    {
        public Phone(Price price, DateTime date, string brand, string model, string office, string imei, string os) : base(price, date, brand, model, office)
        {
            
        }
        public override string AssetType { get => "Phone"; }
    }
}
