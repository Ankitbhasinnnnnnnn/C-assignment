using System;
using System.Collections.Generic;

namespace CRICKET.Models
{
    public partial class Stadium
    {
        public string StadiumName { get; set; }
        public int? StadiumMatches { get; set; }
        public long? StadiumCount { get; set; }
        public int? StadiumId { get; set; }

        public Country StadiumNavigation { get; set; }
    }
}
