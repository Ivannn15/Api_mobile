using System;
using System.Collections.Generic;

namespace Api_mobile.Models
{
    public partial class Type
    {
        public Type()
        {
            Devices = new HashSet<Device>();
        }

        public int IdType { get; set; }
        public string? NameType { get; set; }
        public string? ImageUrl { get; set; }
        public DateOnly? DateAdd { get; set; }
        public DateOnly? DateChange { get; set; }
        public DateOnly? DateDelete { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
    }
}
