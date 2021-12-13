using System;
using System.Collections.Generic;
using System.Text;

namespace LabbXamarin.Models
{
    public class BrawlHallaLegends
    {

        public int legend_id { get; set; }
        public string legend_name_key { get; set; }

        public string bio_name { get; set; }
        public string bio_aka { get; set; }
        public string weapon_on { get; set; }
        public string weapon_two { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int defense { get; set; }
        public int speed { get; set; } 

    }
}
