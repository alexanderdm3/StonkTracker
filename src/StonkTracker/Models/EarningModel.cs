using System.Collections.Generic;

namespace StonkTracker.Models
{
    public class EarningModel
    {
        public string Symbol { get; set; }
        public IEnumerable<Earnings> AnnualEarnings { get; set; }
        public IEnumerable<QuarterlyEarnings> QuarterlyEarnings { get; set; }
    }

}
