using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTrack.PL.Entities
{
    public class EnviromentalThreshold
    {
        public long EnviromentalThresholdId { get; set; }
        public long UserId { get; set; }
        public int TopicId { get; set; }
        public double Value { get; set; }

    }
}
