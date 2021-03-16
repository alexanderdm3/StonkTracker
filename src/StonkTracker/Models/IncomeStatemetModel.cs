using System;
using System.Collections.Generic;

namespace StonkTracker.Models
{
    public class IncomeStatemetModel
    {
        public String Symbol { get; set; }
        public IEnumerable<IncomeStatementReport> AnnualRports { get; set; }
        public IEnumerable<IncomeStatementReport> QuarterlyReports { get; set; }
    }
}
