﻿using System;
using System.Collections.Generic;

namespace R.ARC.Core.Entity.Models
{
    public partial class GeofenceBorderPoints
    {
        public int Id { get; set; }
        public int? FenceId { get; set; }
        public string Hash { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public int? PointOrder { get; set; }
    }
}
