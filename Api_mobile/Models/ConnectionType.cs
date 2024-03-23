using System;
using System.Collections.Generic;

namespace Api_mobile.Models
{
    public partial class ConnectionType
    {
        public ConnectionType()
        {
            Devices = new HashSet<Device>();
        }

        public int IdConnectionType { get; set; }
        public string? NameConnectionType { get; set; }
        public DateOnly? DateAdd { get; set; }
        public DateOnly? DateChange { get; set; }
        public DateOnly? DateDelete { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
    }
}
