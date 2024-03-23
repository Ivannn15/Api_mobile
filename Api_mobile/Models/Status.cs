using System;
using System.Collections.Generic;

namespace Api_mobile.Models
{
    public partial class Status
    {
        public Status()
        {
            Devices = new HashSet<Device>();
        }

        public int IdStatus { get; set; }
        public string? NameStatus { get; set; }
        public DateOnly? DateAdd { get; set; }
        public DateOnly? DateChange { get; set; }
        public DateOnly? DateDelete { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
    }
}
