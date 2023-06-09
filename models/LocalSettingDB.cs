// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using Realms;

namespace corsano_realm_converter_csharp.models
{
    public class LocalSettingDB : RealmObject
    {
        [PrimaryKey]
        [Required]
        [MapTo("key")]
        public string Key { get; set; }

        [Required]
        [MapTo("value")]
        public string Value { get; set; }
    }
}
