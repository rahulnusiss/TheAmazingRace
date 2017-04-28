namespace ACETreasureHunt.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ACETreasureHunt.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ACETreasureHunt.DAL.ACEContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ACETreasureHunt.DAL.ACEContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Events.AddOrUpdate(
             p => p.Id,
             new Event { Name = "BhaagMilkha", Address = "Take it or not", StartDate = new DateTime(2017, 2, 2), Id = 1, StartLatitude = 1.3046014, StartLongitude = 103.7701238 },
             new Event { Name = "SherlockHolmes", Address = "Take it or not", StartDate = new DateTime(2017, 3, 3), Id = 2, StartLatitude = 1.3046014, StartLongitude = 103.8701238 },
             new Event { Name = "NUSTreasureHunt", Address = "Take it or not", StartDate = new DateTime(2017, 4, 5), Id = 3, StartLatitude = 1.2946014, StartLongitude = 103.7701238 }
           );

            context.Teams.AddOrUpdate(
              p => p.Id,
              new Team { Name = "Instant1", Description = "askjdhkjahkjhjwqkf", EventID = 1, Id = 1 },
              new Team { Name = "NoBreak2", Description = "dajfiauhuaiue", EventID = 2, Id = 2 },
              new Team { Name = "Lethal3", Description = "mmnnvnjdjeurur", EventID = 3, Id = 3 },
              new Team { Name = "RunForrest1", Description = "PPPPPPP", EventID = 1, Id = 4 },
              new Team { Name = "Charlie2", Description = "JJJJJsssss", EventID = 2, Id = 5 },
              new Team { Name = "Tom3", Description = "YYYY", EventID = 3, Id = 6 },
              new Team { Name = "Alone1", Description = "JJJJJ", EventID = 1, Id = 7 },
              new Team { Name = "NeverBackDown2", Description = "MMMMM", EventID = 2, Id = 8 },
              new Team { Name = "Hangover3", Description = "NNNN", EventID = 3, Id = 9 }
            );

            context.PitStops.AddOrUpdate(
              p => p.Id,
              new PitStop { PitStopName = "Raffles Place", PitStopNumber = 1, Latitude = 1.2838627, Longitude = 103.8493554, Description = "WAH", EventID = 1, Id = 1 },
              new PitStop { PitStopName = "Bugis", PitStopNumber = 2, Latitude = 1.300599, Longitude = 103.8527043, Description = "DDD", EventID = 1, Id = 2 },
              new PitStop { PitStopName = "Lavendar", PitStopNumber = 3, Latitude = 1.3075337, Longitude = 103.8609886, Description = "WAH", EventID = 1, Id = 3 },
              new PitStop { PitStopName = "chinatown", PitStopNumber = 1, Latitude = 1.2850, Longitude = 103.8440, Description = "WAH", EventID = 2, Id = 4 },
              new PitStop { PitStopName = "Clarke-Quay", PitStopNumber = 2, Latitude = 1.2889, Longitude = 103.8472, Description = "WAH", EventID = 2, Id = 5 },
              new PitStop { PitStopName = "Dhoby Ghaut ", PitStopNumber = 3, Latitude = 1.2988, Longitude = 103.8452, Description = "WAH", EventID = 2, Id = 6 },
              new PitStop { PitStopName = "Orchard", PitStopNumber = 1, Latitude = 1.3031, Longitude = 103.8322, Description = "WAH", EventID = 3, Id = 7 },
              new PitStop { PitStopName = "Dhoby Ghaut ", PitStopNumber = 2, Latitude = 1.2988, Longitude = 103.8452, Description = "WAH", EventID = 3, Id = 8 },
              new PitStop { PitStopName = "Lavendar", PitStopNumber = 3, Latitude = 1.3075337, Longitude = 103.8609886, Description = "WAH", EventID = 3, Id = 9 }
              );

        }
    }
}
