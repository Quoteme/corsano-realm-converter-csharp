// Please note : [Backlink] properties and default values are not represented
// in the schema and thus will not be part of the generated models

using System;
using System.Collections.Generic;
using Realms;

namespace MyProject.Models
{
    public class StepsSummaryModel : RealmObject
    {
        [PrimaryKey]
        [Required]
        [MapTo("serverDate")]
        public string ServerDate { get; set; }

        [Required]
        [MapTo("uuid")]
        public string Uuid { get; set; }

        [MapTo("stepsSlots")]
        public IList<StepsSlotModel> StepsSlots { get; }

        [MapTo("stepCount")]
        public long StepCount { get; set; }

        [MapTo("stepDistance")]
        public float StepDistance { get; set; }

        [MapTo("stepCalories")]
        public long StepCalories { get; set; }

        [MapTo("goalStepPercentage")]
        public long GoalStepPercentage { get; set; }

        [MapTo("moveEveryHour")]
        public long MoveEveryHour { get; set; }

        [MapTo("workoutsCount")]
        public long WorkoutsCount { get; set; }

        [MapTo("startTimestamp")]
        public long StartTimestamp { get; set; }

        [MapTo("endTimestamp")]
        public long EndTimestamp { get; set; }
    }
}
