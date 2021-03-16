using System;
namespace StonkTracker.Models
{
    public class IncomeStatementReport
    {
        public string FiscalDateEnding { get; set;}
        public string ReportedCurrency { get; set; }
        public string GrossProfit { get; set; }
        public string TotalReveue { get; set; }
        public string CostOfRevenue { get; set; }
        public string CostOfGoodsAndServicesSold { get; set; }
        public string OpertionIncome { get; set; }
        public string SellingGeneralAndAdministrative { get; set; }
        public string rRsearchAndDevelopment { get; set; }
        public string OperatingExpenses { get; set; }
        public string InvestmentIncomeNet { get; set; }
        public string NetInterestIncome { get; set; }
        public string InterestIncome { get; set; }
        public string InterestExpense { get; set; }
        public string NonInterestIncome { get; set; }
        public string PtherNonIntrestIncome { get; set; }
        public string Depreciation { get; set; }
        public string DepreciationAndAmortization { get; set; }
        public string IncomeBeforeTax { get; set; }
        public string IncomeTaxExpense { get; set; }
        public string InterestAndDebtExpense { get; set; }
        public string NetIncomeFromContinuingOperations { get; set; }
        public string comprehensiveIncomeNetOfTax { get; set; }
        public string ebit { get; set; }
        public string ebitda { get; set; }
        public string netIncome { get; set; }
    }
}
