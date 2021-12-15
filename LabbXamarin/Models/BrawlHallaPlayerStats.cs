using System;
using System.Collections.Generic;
using System.Text;

namespace LabbXamarin.Models
{
    public class BrawlHallaPlayerStats
    {

        public int brawlhalla_id { get; set; }
        public string name { get; set; }
        public int xp { get; set; }
        public int level  { get; set; }
        public double xp_percentage { get; set; }
        public int games { get; set; }
        public int wins { get; set; }
        public string damagebomb { get; set; }
        public List<PlayerLegends> legends { get; set; }



    }
}
