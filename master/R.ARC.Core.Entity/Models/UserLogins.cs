﻿using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class UserLogins
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public int UserId { get; set; }

        public virtual Users User { get; set; }
    }
}
