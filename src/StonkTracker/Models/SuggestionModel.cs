using System;

namespace StonkTracker.Models
{
    public class SuggestionModel
    {
        public string Symbol { get; set; }
        public DateTime SuggestionTime { get; set; }
        public double BuyAt { get; set; }
        public double SellAtInitial { get; set; }
        public double SellAtSecondary { get; set; }

        public SuggestionModel(string symbol, string date, string time, string buyAt, string sellAtInitial, string sellAtSecondary)
        {
            try
            {
                var day = DateTime.Parse(date);
                var timeOfDay = DateTime.Parse(time);

                Symbol = symbol;
                SuggestionTime = day.Date + timeOfDay.TimeOfDay;
                BuyAt = Convert.ToDouble(buyAt);
                SellAtInitial = Convert.ToDouble(sellAtInitial);
                SellAtSecondary = Convert.ToDouble(sellAtSecondary);

            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
