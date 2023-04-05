// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using Realms;

namespace corsano_realm_converter_csharp.models
{
    public class RawFileChunk : RealmObject
    {
        [PrimaryKey]
        [Required]
        [MapTo("fileName")]
        public string FileName { get; set; }

        [MapTo("timestamp")]
        public long Timestamp { get; set; }

        [Required]
        [MapTo("watchAddress")]
        public string WatchAddress { get; set; }

        [MapTo("size")]
        public long Size { get; set; }

        [MapTo("crc")]
        public long Crc { get; set; }

        [MapTo("deletedFromWatch")]
        public bool DeletedFromWatch { get; set; }

        [MapTo("status")]
        public long Status { get; set; }

        [Required]
        [MapTo("type")]
        public string Type { get; set; }
    }
}
