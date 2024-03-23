using System;
using System.Collections.Generic;

namespace Api_mobile.Models
{
    public partial class Script
    {
        public int IdScript { get; set; }
        public string? NameScript { get; set; }
        public string? DescriptionString { get; set; }
        public DateOnly? DateAdd { get; set; }
        public DateOnly? DateChange { get; set; }
        public DateOnly? DateDelete { get; set; }
        public DateOnly? StartTime { get; set; }
        public int? IdRegularity { get; set; }

        public virtual Regularity? IdRegularityNavigation { get; set; }
    }
}
