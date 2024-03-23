using System;
using System.Collections.Generic;

namespace Api_mobile.Models
{
    public partial class Step
    {
        public int IdStep { get; set; }
        public string? NameStep { get; set; }
        public DateOnly? DateAdd { get; set; }
        public DateOnly? DateChange { get; set; }
        public DateOnly? DateDelete { get; set; }
        public int? Priority { get; set; }
        public int? IdDevices { get; set; }
        public int? IdCommandToTheDevice { get; set; }

        public virtual CommandToTheDevice? IdCommandToTheDeviceNavigation { get; set; }
        public virtual Device? IdDevicesNavigation { get; set; }
    }
}
