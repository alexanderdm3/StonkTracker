using System;
namespace StonkTracker.Models
{
    public class CompositeTimeSeriesModel
    {
        public DateTime Occurance { get; set; }
        public TimeSeriesModel Model { get; set; }

        public CompositeTimeSeriesModel(DateTime occurrance, TimeSeriesModel model)
        {
            Occurance = occurrance;
            Model = model;
        }
    }
}
