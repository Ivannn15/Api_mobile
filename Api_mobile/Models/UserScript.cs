using System;
using System.Collections.Generic;

namespace Api_mobile.Models
{
    public partial class UserScript
    {
        public int IdScript { get; set; }
        public int IdUser { get; set; }

        public virtual Script IdScriptNavigation { get; set; } = null!;
        public virtual User IdUserNavigation { get; set; } = null!;
    }
}
