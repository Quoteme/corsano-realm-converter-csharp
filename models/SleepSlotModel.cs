// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using System;
using System.Collections.Generic;
using Realms;

namespace MyProject.Models
{
    public class SleepSlotModel : RealmObject
    {
        [PrimaryKey]
        [MapTo("timestamp")]
        public long Timestamp { get; set; }

        [Required]
        [MapTo("startDate")]
        public string StartDate { get; set; }

        [Required]
        [MapTo("endDate")]
        public string EndDate { get; set; }

        [MapTo("sleepState")]
        public long SleepState { get; set; }
    }
}
