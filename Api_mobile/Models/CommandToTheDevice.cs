using System;
using System.Collections.Generic;

namespace Api_mobile.Models
{
    public partial class CommandToTheDevice
    {
        public CommandToTheDevice()
        {
            Steps = new HashSet<Step>();
        }

        public int IdDevices { get; set; }
        public int IdCommandToTheDevice { get; set; }
        public DateOnly? DateAdd { get; set; }
        public DateOnly? DateChange { get; set; }
        public DateOnly? DateDelete { get; set; }
        public string? DescriptionOfTheCommand { get; set; }
        public string? NumOfCommand { get; set; }

        public virtual Device IdDevicesNavigation { get; set; } = null!;
        public virtual ICollection<Step> Steps { get; set; }
    }
}
