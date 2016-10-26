namespace ppRadWeek62.Migration.ClubsMigrations
{
    using Microsoft.Ajax.Utilities;
    using Models.ClubsModel;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ppRadWeek62.Models.ClubsModel.ClubsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migration\ClubsMigrations";
        }

        protected override void Seed(ppRadWeek62.Models.ClubsModel.ClubsContext context)
        {
            context.Clubs.AddOrUpdate(c => c.ClubName,
                new Club
                {
                    ClubName = "Tiddly Winks Club",
                    CreationDate = DateTime.Now
                });
            context.Clubs.AddOrUpdate(c => c.ClubName,
                new Club
                {
                    ClubName = "The Chess Club",
                    CreationDate = DateTime.Now
                });
        }
    }
}
