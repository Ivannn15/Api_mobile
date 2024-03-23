using System;
using System.Collections.Generic;

namespace Api_mobile.Models
{
    public partial class DevicesScript
    {
        public int IdScript { get; set; }
        public int IdDevices { get; set; }

        public virtual Device IdDevicesNavigation { get; set; } = null!;
        public virtual Script IdScriptNavigation { get; set; } = null!;
    }
}
