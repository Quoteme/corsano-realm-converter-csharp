// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using System;
using System.Collections.Generic;
using Realms;

namespace MyProject.Models
{
    public class SpO2SummaryModel : RealmObject
    {
        [PrimaryKey]
        [Required]
        [MapTo("serverDate")]
        public string ServerDate { get; set; }

        [Required]
        [MapTo("uuid")]
        public string Uuid { get; set; }

        [MapTo("average")]
        public long Average { get; set; }

        [MapTo("slots")]
        public IList<Spo2SlotModel> Slots { get; }

        [MapTo("startTimestamp")]
        public long StartTimestamp { get; set; }

        [MapTo("endTimestamp")]
        public long EndTimestamp { get; set; }
    }
}
