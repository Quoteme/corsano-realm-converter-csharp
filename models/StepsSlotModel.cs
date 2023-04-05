// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using System;
using System.Collections.Generic;
using Realms;

namespace MyProject.Models
{
    public class StepsSlotModel : RealmObject
    {
        [PrimaryKey]
        [MapTo("timestamp")]
        public long Timestamp { get; set; }

        [Required]
        [MapTo("date")]
        public string Date { get; set; }

        [MapTo("stepCount")]
        public long StepCount { get; set; }

        [MapTo("energyExp")]
        public double EnergyExp { get; set; }

        [MapTo("speed")]
        public double? Speed { get; set; }

        [MapTo("activityType")]
        public long? ActivityType { get; set; }
    }
}
