using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_3_Asset_Tracking
{
    class CurrencyObj
    {
        public CurrencyObj(string currencyCode, double rate) 
        {
            CurrencyCode = currencyCode;
            ExchangeRateFromEUR = rate;
        }
        public string CurrencyCode { get; private set; }
        public double ExchangeRateFromEUR { get; private set; }
    }
}
