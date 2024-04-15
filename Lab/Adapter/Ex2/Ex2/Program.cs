using System;
using System.IO;
using System.Text;


//Integrate two exchange rate services, VCB and DAB, into an existing program with a hard-coded exchange rate interface
// VCB and DAB have different methods for fetching rates.

namespace Ex2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var service = new ExchangeRateService();
            //Client(service);

        }
    }
    public class ExchangeRate
    {
        public required string CurrencyCode { get; set; }
        public double Buy { get; set; }
        public double Sell { get; set; }
    }

    public interface IExchangeRateService
    {
        List<ExchangeRate> GetList();
    }

    public class ExchangeRateService : IExchangeRateService
    {
        public List<ExchangeRate> GetList()
        {
            return new List<ExchangeRate>
            {
                new() { CurrencyCode = "USD", Buy = 24_000, Sell = 24_500 }
            };
        }
    }
}
