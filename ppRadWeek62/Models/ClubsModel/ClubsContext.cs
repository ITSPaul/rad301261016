using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ppRadWeek62.Models.ClubsModel
{
    public class ClubsContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }
        public DbSet<Member> members { get; set; }
        public ClubsContext() : base("DefaultConnection")
        {

        }
        public static ClubsContext Create()
        {
            return new ClubsContext();
        }
    }
}