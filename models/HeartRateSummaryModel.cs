// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using Realms;

namespace corsano_realm_converter_csharp.models
{
    public class HeartRateSummaryModel : RealmObject
    {
        [PrimaryKey]
        [Required]
        [MapTo("serverDate")]
        public string ServerDate { get; set; }

        [Required]
        [MapTo("uuid")]
        public string Uuid { get; set; }

        [MapTo("heartRateSlots")]
        public IList<HeartRateSlotModel> HeartRateSlots { get; }

        [MapTo("avgDailyHeartRate")]
        public long AvgDailyHeartRate { get; set; }

        [MapTo("maxDailyHeartRate")]
        public long MaxDailyHeartRate { get; set; }

        [MapTo("restDailyHeartRate")]
        public long RestDailyHeartRate { get; set; }

        [MapTo("allActiveTime")]
        public long AllActiveTime { get; set; }

        [MapTo("maxHeartRateTime")]
        public long MaxHeartRateTime { get; set; }

        [MapTo("performanceHeartRateTime")]
        public long PerformanceHeartRateTime { get; set; }

        [MapTo("enduranceHeartRateTime")]
        public long EnduranceHeartRateTime { get; set; }

        [MapTo("fatBurnHeartRateTime")]
        public long FatBurnHeartRateTime { get; set; }

        [MapTo("warmUpHeartRateTime")]
        public long WarmUpHeartRateTime { get; set; }

        [MapTo("restHeartRateTime")]
        public long RestHeartRateTime { get; set; }

        [MapTo("dailyPercent")]
        public long? DailyPercent { get; set; }

        [MapTo("startTimestamp")]
        public long StartTimestamp { get; set; }

        [MapTo("endTimestamp")]
        public long EndTimestamp { get; set; }
    }
}
