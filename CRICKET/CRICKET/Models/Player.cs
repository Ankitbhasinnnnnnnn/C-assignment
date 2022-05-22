using System;
using System.Collections.Generic;

namespace CRICKET.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerAge { get; set; }
        public int? CountryId { get; set; }

        public Country Country { get; set; }
    }
}
