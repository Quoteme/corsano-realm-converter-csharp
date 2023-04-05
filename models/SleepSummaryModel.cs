// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using System;
using System.Collections.Generic;
using Realms;

namespace MyProject.Models
{
    public class SleepSummaryModel : RealmObject
    {
        [PrimaryKey]
        [Required]
        [MapTo("serverDate")]
        public string ServerDate { get; set; }

        [Required]
        [MapTo("uuid")]
        public string Uuid { get; set; }

        [MapTo("sleepDuration")]
        public long SleepDuration { get; set; }

        [MapTo("sleepSlots")]
        public IList<SleepSlotModel> SleepSlots { get; }

        [MapTo("goalSleepPercentage")]
        public long GoalSleepPercentage { get; set; }

        [MapTo("sleepNeedDuration")]
        public long SleepNeedDuration { get; set; }

        [MapTo("awakeTime")]
        public long AwakeTime { get; set; }

        [MapTo("remTime")]
        public long RemTime { get; set; }

        [MapTo("lightTime")]
        public long LightTime { get; set; }

        [MapTo("deepTime")]
        public long DeepTime { get; set; }

        [MapTo("performance")]
        public long Performance { get; set; }

        [MapTo("tranquility")]
        public long Tranquility { get; set; }

        [MapTo("date")]
        public DateTimeOffset Date { get; set; }
    }
}
