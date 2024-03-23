using System;
using System.Collections.Generic;

namespace Api_mobile.Models
{
    public partial class Device
    {
        public Device()
        {
            CommandToTheDevices = new HashSet<CommandToTheDevice>();
            Steps = new HashSet<Step>();
        }

        public int IdDevices { get; set; }
        public string? NameDevices { get; set; }
        public string? DescriptionDevices { get; set; }
        public DateOnly? DateAdd { get; set; }
        public DateOnly? DateChange { get; set; }
        public DateOnly? DateDelete { get; set; }
        public int IdType { get; set; }
        public int IdStatus { get; set; }
        public int IdConnectionType { get; set; }
        public string? Model { get; set; }

        public virtual ConnectionType IdConnectionTypeNavigation { get; set; } = null!;
        public virtual Status IdStatusNavigation { get; set; } = null!;
        public virtual Type IdTypeNavigation { get; set; } = null!;
        public virtual ICollection<CommandToTheDevice> CommandToTheDevices { get; set; }
        public virtual ICollection<Step> Steps { get; set; }
    }
}
