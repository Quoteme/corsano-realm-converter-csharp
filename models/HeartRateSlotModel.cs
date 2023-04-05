// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using Realms;

namespace corsano_realm_converter_csharp.models
{
    public class HeartRateSlotModel : RealmObject
    {
        [PrimaryKey]
        [MapTo("timestamp")]
        public long Timestamp { get; set; }

        [Required]
        [MapTo("date")]
        public string Date { get; set; }

        [MapTo("bpm")]
        public long? Bpm { get; set; }

        [MapTo("bpm_q")]
        public long? Bpm_q { get; set; }
    }
}
