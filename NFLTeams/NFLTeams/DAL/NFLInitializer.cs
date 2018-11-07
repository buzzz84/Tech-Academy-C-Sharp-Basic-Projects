using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NFLTeams.Models;

namespace NFLTeams.DAL
{
    public class NFLInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<NFLContext>
    {
        protected override void Seed(NFLContext context)
        {
            var players = new List<Player>
            {
                new Player{FirstName="Russell",LastName="Wilson",Position="QB",Number="3" },
                new Player{FirstName="Aaron",LastName="Rodgers",Position="QB",Number="12"},
                new Player{FirstName="Julio",LastName="Jones",Position="WR",Number="11" }
            };

            players.ForEach(p => context.Players.Add(p));
            context.SaveChanges();
            var coaches = new List<Coach>
            {
                new Coach{CoachId=1,CoachName="Pete Carroll",CoachPosition="Head Coach"},
                new Coach{CoachId=2,CoachName="Mike McCarthy",CoachPosition="Head Coach"},
                new Coach{CoachId=3,CoachName="Dan Quinn",CoachPosition="Head Coach"}
            };
            coaches.ForEach(p => context.Coaches.Add(p));
            context.SaveChanges();
            var teams = new List<Team>
            {
                new Team{PlayerId=1,CoachId=1,City="Seattle",NickName="Seahawks",PlayoffChance=PlayoffChance.Contender},
                new Team{PlayerId=2,CoachId=2,City="Green Bay",NickName="Packers",PlayoffChance=PlayoffChance.SBBound},
                new Team{PlayerId=3,CoachId=3,City="Atlanta",NickName="Falcons",PlayoffChance=PlayoffChance.Pretender}
            };
            teams.ForEach(p => context.Teams.Add(p));
            context.SaveChanges();
        }
    }
}