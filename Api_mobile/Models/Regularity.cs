using System;
using System.Collections.Generic;

namespace Api_mobile.Models
{
    public partial class Regularity
    {
        public Regularity()
        {
            Scripts = new HashSet<Script>();
        }

        public int IdRegularity { get; set; }
        public string NameRegularity { get; set; } = null!;
        public DateOnly? DateChange { get; set; }
        public DateOnly? DateAdd { get; set; }
        public DateOnly? DateDelete { get; set; }

        public virtual ICollection<Script> Scripts { get; set; }
    }
}
