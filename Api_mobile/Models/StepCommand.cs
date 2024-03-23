using System;
using System.Collections.Generic;

namespace Api_mobile.Models
{
    public partial class StepCommand
    {
        public int IdCommandToTheDevice { get; set; }
        public int IdStep { get; set; }

        public virtual CommandToTheDevice IdCommandToTheDeviceNavigation { get; set; } = null!;
        public virtual Step IdStepNavigation { get; set; } = null!;
    }
}
