// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using System;
using System.Collections.Generic;
using Realms;

namespace MyProject.Models
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
