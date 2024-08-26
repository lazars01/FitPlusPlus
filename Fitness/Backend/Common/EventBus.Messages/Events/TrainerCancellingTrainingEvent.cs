﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Messages.Events
{
    public class TrainerCancellingTrainingEvent
    {
        public string ClientId { get; set; }
        public string TrainerId { get; set; }
        public TimeSpan Duration { get; set; }
        public int WeekId { get; set; }
        public string DayName { get; set; }
        public int StartHour { get; set; }
        public int StartMinute { get; set; }
    }
}
