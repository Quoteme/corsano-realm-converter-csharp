// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using System;
using System.Collections.Generic;
using Realms;

namespace MyProject.Models
{
    public class EmographySummaryModel : RealmObject
    {
        [PrimaryKey]
        [Required]
        [MapTo("serverDate")]
        public string ServerDate { get; set; }

        [Required]
        [MapTo("uuid")]
        public string Uuid { get; set; }

        [MapTo("slots")]
        public IList<EmographySlotModel> Slots { get; }

        [MapTo("stressLevelSkinConductanceAvg")]
        public long StressLevelSkinConductanceAvg { get; set; }

        [MapTo("startTimestamp")]
        public long StartTimestamp { get; set; }

        [MapTo("endTimestamp")]
        public long EndTimestamp { get; set; }
    }
}
