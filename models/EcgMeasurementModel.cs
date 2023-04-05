// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using Realms;

namespace corsano_realm_converter_csharp.models
{
    public class EcgMeasurementModel : RealmObject
    {
        [PrimaryKey]
        [MapTo("startTimestamp")]
        public long StartTimestamp { get; set; }

        [MapTo("endTimestamp")]
        public long? EndTimestamp { get; set; }

        [MapTo("wiffFilename")]
        public string WiffFilename { get; set; }
    }
}
