// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using Realms;

namespace corsano_realm_converter_csharp.models
{
    public class MetricActivity : RealmObject
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

        [MapTo("q")]
        public long? Q { get; set; }

        [MapTo("last_steps")]
        public long? Last_steps { get; set; }

        [MapTo("activity_type")]
        public long? Activity_type { get; set; }

        [MapTo("speed")]
        public double? Speed { get; set; }

        [MapTo("spo2")]
        public long? Spo2 { get; set; }

        [MapTo("spo2Q")]
        public long? Spo2Q { get; set; }

        [MapTo("energy_exp")]
        public long? Energy_exp { get; set; }

        [MapTo("respiration_rate")]
        public float? Respiration_rate { get; set; }

        [MapTo("pha")]
        public long? Pha { get; set; }

        [MapTo("pha_q")]
        public long? Pha_q { get; set; }

        [MapTo("resp_q")]
        public long? Resp_q { get; set; }

        [MapTo("wearing")]
        public long? Wearing { get; set; }

        [MapTo("move_alert")]
        public long? Move_alert { get; set; }

        [MapTo("cw")]
        public long? Cw { get; set; }

        [MapTo("cwt")]
        public long? Cwt { get; set; }

        [MapTo("battery")]
        public long? Battery { get; set; }

        [MapTo("step_calories")]
        public long? Step_calories { get; set; }

        [MapTo("rest_calories")]
        public long? Rest_calories { get; set; }

        [MapTo("distance")]
        public long? Distance { get; set; }

        [MapTo("step_duration")]
        public long? Step_duration { get; set; }

        [MapTo("active_calories")]
        public long? Active_calories { get; set; }

        [MapTo("isSynced")]
        public bool IsSynced { get; set; }
    }
}
