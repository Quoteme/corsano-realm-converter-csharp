// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using Realms;

namespace corsano_realm_converter_csharp.models
{
    public class MetricPpg : RealmObject
    {
        [PrimaryKey]
        [MapTo("timestamp")]
        public long Timestamp { get; set; }

        [Required]
        [MapTo("date")]
        public string Date { get; set; }

        [MapTo("acc")]
        public long Acc { get; set; }

        [MapTo("ppg")]
        public long Ppg { get; set; }

        [MapTo("bpm")]
        public long Bpm { get; set; }

        [MapTo("bpmQ")]
        public long BpmQ { get; set; }

        [MapTo("crc")]
        public long Crc { get; set; }

        [MapTo("accX")]
        public long? AccX { get; set; }

        [MapTo("accY")]
        public long? AccY { get; set; }

        [MapTo("accZ")]
        public long? AccZ { get; set; }

        [MapTo("isSynced")]
        public bool IsSynced { get; set; }
    }
}
