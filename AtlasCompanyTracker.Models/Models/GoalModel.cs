using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlasCompanyTracker.Models.Models
{
    public class GoalModel
    {
        public int ID { get; private set; }
        public Guid GoalGuid { get; private set; }
        public int StartingQuantity { get; set; }
        public int EndingQuantity { get; set; }
        public int Timeframe { get; set; }
        public ResourceModel Resource { get; set; }
        public enum TimeframeEnum
        {
            Day = 0,
            Week,
            Month
        }

        public GoalModel()
        {
            GoalGuid = Guid.NewGuid();
        }
    }
}
