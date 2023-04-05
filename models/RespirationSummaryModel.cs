// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using Realms;

namespace corsano_realm_converter_csharp.models
{
    public class RespirationSummaryModel : RealmObject
    {
        [PrimaryKey]
        [Required]
        [MapTo("serverDate")]
        public string ServerDate { get; set; }

        [Required]
        [MapTo("uuid")]
        public string Uuid { get; set; }

        [MapTo("average")]
        public float Average { get; set; }

        [MapTo("slots")]
        public IList<RespirationSlotModel> Slots { get; }

        [MapTo("startTimestamp")]
        public long StartTimestamp { get; set; }

        [MapTo("endTimestamp")]
        public long EndTimestamp { get; set; }
    }
}
