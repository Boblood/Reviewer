namespace Reviewer.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Reviewer.GRDB_D1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Reviewer.GRDB_D1";
        }

        protected override void Seed(Reviewer.GRDB_D1 context)
        {
            context.Games.AddOrUpdate(x => x.ID,
                new Game
                {
                    ID = 1,
                    Name = "Super Mario Brothers",
                    Publisher = "Nintendo",
                    ReleaseDate = new DateTime(1985, 9, 13),
                    GameConsoles = new List<GameSystem>() { GameSystem.NES },
                    Description = "The first Console Mario",
                    ReasonForGreatness = "OG status"
                },
                new Game
                {
                    ID = 2,
                    Name = "The Legend of Zelda",
                    Publisher = "Nintendo",
                    ReleaseDate = new DateTime(1986, 2, 21),
                    GameConsoles = new List<GameSystem>() { GameSystem.NES },
                    Description = "The first Console Zelda",
                    ReasonForGreatness = "OG status"
                },
                new Game
                {
                    ID = 3,
                    Name = "Halo: Combat Evolved",
                    Publisher = "Microsoft Game Studios",
                    ReleaseDate = new DateTime(2001, 11, 15),
                    GameConsoles = new List<GameSystem>() { GameSystem.Xbox, GameSystem.Xbox360 },
                    Description = "The first Console Halo",
                    ReasonForGreatness = "OG status and impact on Game community"
                });
        }
    }
}