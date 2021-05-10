using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class Currency
    {
        public string Value { get; set; }

        public Currency(string value) { Value = value; }
        public static Currency AUD { get { return new Currency("AUD"); } }
        public static Currency BGN { get { return new Currency("BGN"); } }
        public static Currency BRL { get { return new Currency("BRL"); } }
        public static Currency CAD { get { return new Currency("CAD"); } }
        public static Currency CHF { get { return new Currency("CHF"); } }
        public static Currency CNY { get { return new Currency("CNY"); } }
        public static Currency CZK { get { return new Currency("CZK"); } }
        public static Currency DKK { get { return new Currency("DKK"); } }
        public static Currency EUR { get { return new Currency("EUR"); } }
        public static Currency GBP { get { return new Currency("GBP"); } }
        public static Currency HKD { get { return new Currency("HKD"); } }
        public static Currency HRK { get { return new Currency("HRK"); } }
        public static Currency HUF { get { return new Currency("HUF"); } }
        public static Currency IDR { get { return new Currency("IDR"); } }
        public static Currency ILS { get { return new Currency("ILS"); } }
        public static Currency INR { get { return new Currency("INR"); } }
        public static Currency JPY { get { return new Currency("JPY"); } }
        public static Currency KRW { get { return new Currency("KRW"); } }
        public static Currency MXN { get { return new Currency("MXN"); } }
        public static Currency MYR { get { return new Currency("MYR"); } }
        public static Currency NOK { get { return new Currency("NOK"); } }
        public static Currency NZD { get { return new Currency("NZD"); } }
        public static Currency PHP { get { return new Currency("PHP"); } }
        public static Currency PLN { get { return new Currency("PLN"); } }
        public static Currency RON { get { return new Currency("RON"); } }
        public static Currency RUB { get { return new Currency("RUB"); } }
        public static Currency SEK { get { return new Currency("SEK"); } } 
        public static Currency SGD { get { return new Currency("SGD"); } }
        public static Currency THB { get { return new Currency("THB"); } }
        public static Currency TRY { get { return new Currency("TRY"); } }
        public static Currency USD { get { return new Currency("USD"); } }
        public static Currency ZAR { get { return new Currency("ZAR"); } }
    }
}
