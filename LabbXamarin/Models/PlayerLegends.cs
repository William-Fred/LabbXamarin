using System;
using System.Collections.Generic;
using System.Text;

namespace LabbXamarin.Models
{
    public class PlayerLegends
    {
        public int legend_id { get; set; }
        public string legend_name_key { get; set; }
        public string damagedealt { get; set; }
        public string damagetaken { get; set; }
        public int kos { get; set; }
        public int wins { get; set; }
        public int games { get; set; }
    }
}
