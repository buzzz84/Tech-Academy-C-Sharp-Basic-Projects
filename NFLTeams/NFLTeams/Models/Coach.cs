using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NFLTeams.Models
{
    public class Coach
    {
        public int CoachId { get; set; }
        public string CoachName { get; set; }
        public string CoachPosition { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}