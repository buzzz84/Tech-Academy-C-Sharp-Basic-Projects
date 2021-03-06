﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NFLTeams.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Number { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}