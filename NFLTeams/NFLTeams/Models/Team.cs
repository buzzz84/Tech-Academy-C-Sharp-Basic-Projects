using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NFLTeams.Models
{
    public enum PlayoffChance
    {
        SBBound, Contender, Pretender, FirstPickInSight
    }
    public class Team
    {
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public int CoachId { get; set; }
        public string City { get; set; }
        public string NickName { get; set; }
        public PlayoffChance? PlayoffChance { get; set; }

        public virtual Player Player { get; set; }
        public virtual Coach Coach { get; set; }
    }
}