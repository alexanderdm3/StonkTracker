using System;
namespace StonkTracker.Models
{
    public class QuarterlyEarnings : Earnings
    {
        public string ReportedDate { get; set; }
        public string EstrimatatedEPS { get; set; }
        public string Suprise { get; set; }
        public string SuprisePercentage { get; set; }
    }
}
