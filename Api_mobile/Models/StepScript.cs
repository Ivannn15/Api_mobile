using System;
using System.Collections.Generic;

namespace Api_mobile.Models
{
    public partial class StepScript
    {
        public int IdStep { get; set; }
        public int IdScript { get; set; }

        public virtual Script IdScriptNavigation { get; set; } = null!;
        public virtual Step IdStepNavigation { get; set; } = null!;
    }
}
