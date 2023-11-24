using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalFancyProductLib
{
    public class Hat
    {
        private string _shortName;
        private string _longName;
        private double _basePrice;
        private const double TAX = .08;


        public Hat(string shortName, string longName, double basePrice)
        {
            _shortName = shortName;
            _longName = longName;
            _basePrice = basePrice;
        }
        public double GetPrice()
        {
            return (_basePrice + _basePrice * TAX);
        }

        public string GetLongName()
        {
            return _longName;
        }

        public string GetShortName()
        {
            return _shortName;
        }
    }
}
