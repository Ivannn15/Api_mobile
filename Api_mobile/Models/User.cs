using System;
using System.Collections.Generic;

namespace Api_mobile.Models
{
    public partial class User
    {
        public int IdUser { get; set; }
        public string NameUser { get; set; } = null!;
        public string EmailUser { get; set; } = null!;
        public string? SaltUser { get; set; }
        public DateOnly? DateChange { get; set; }
        public DateOnly? DateAdd { get; set; }
        public DateOnly? DateDelete { get; set; }
    }
}
