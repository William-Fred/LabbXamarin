using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Converters;
namespace LabbXamarin.Models
{
    public class BrawlHallaTopFifty
    {
     
            [JsonProperty("rank")]
            public int Rank { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("brawlhalla_id")]
            public int BrawlhallaId { get; set; }

            [JsonProperty("best_legend")]
            public int BestLegend { get; set; }

            [JsonProperty("best_legend_games")]
            public int BestLegendGames { get; set; }

            [JsonProperty("best_legend_wins")]
            public int BestLegendWins { get; set; }

            [JsonProperty("rating")]
            public int Rating { get; set; }

            [JsonProperty("tier")]
            public string Tier { get; set; }

            [JsonProperty("games")]
            public int Games { get; set; }

            [JsonProperty("wins")]
            public int Wins { get; set; }

            [JsonProperty("region")]
            public string Region { get; set; }

            [JsonProperty("peak_rating")]
            public int PeakRating { get; set; }
            public string bestLegendName { get; set; }
            //for toggle
            public bool isVisible { get; set; }
    }
    }
