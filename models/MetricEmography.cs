// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using System;
using System.Collections.Generic;
using Realms;

namespace MyProject.Models
{
    public class MetricEmography : RealmObject
    {
        [PrimaryKey]
        [MapTo("timestamp")]
        public long Timestamp { get; set; }

        [Required]
        [MapTo("date")]
        public string Date { get; set; }

        [MapTo("cognitiveZone")]
        public long CognitiveZone { get; set; }

        [MapTo("predictiveCZ")]
        public long PredictiveCZ { get; set; }

        [MapTo("predictiveCZTransitionTime")]
        public long PredictiveCZTransitionTime { get; set; }

        [MapTo("czHour")]
        public long CzHour { get; set; }

        [MapTo("cortisolContribution")]
        public long CortisolContribution { get; set; }

        [MapTo("cognitiveZoneQ")]
        public long CognitiveZoneQ { get; set; }

        [MapTo("stressLevelSkinConductance")]
        public long StressLevelSkinConductance { get; set; }

        [MapTo("stressLevelSkinConductanceQ")]
        public long StressLevelSkinConductanceQ { get; set; }

        [MapTo("isSynced")]
        public bool IsSynced { get; set; }
    }
}
