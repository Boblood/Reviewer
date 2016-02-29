namespace Reviewer.Migrations
{
    using Models;
    using System;
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
            context.Games.AddOrUpdate(x => x.GameID,
                new Game
                {
                    GameID = 1,
                    Name = "Super Mario Brothers",
                    Publisher = "Nintendo",
                    ReleaseDate = new DateTime(1985, 9, 13),
                    //GameConsoles = new List<GameSystem>() { GameSystem.NES },
                    Description = "The first Console Mario",
                    ReasonForGreatness = "OG status"
                },
                new Game
                {
                    GameID = 2,
                    Name = "The Legend of Zelda",
                    Publisher = "Nintendo",
                    ReleaseDate = new DateTime(1986, 2, 21),
                    //GameConsoles = new List<GameSystem>() { GameSystem.NES },
                    Description = "The first Console Zelda",
                    ReasonForGreatness = "OG status"
                },
                new Game
                {
                    GameID = 3,
                    Name = "Halo: Combat Evolved",
                    Publisher = "Microsoft Game Studios",
                    ReleaseDate = new DateTime(2001, 11, 15),
                    //GameConsoles = new List<GameSystem>() { GameSystem.Xbox, GameSystem.Xbox360 },
                    Description = "The first Console Halo",
                    ReasonForGreatness = "OG status and impact on Game community"
                });

            context.GameGameSystemLinks.AddOrUpdate(x => x.ID,
                new GameGameSystemLink
                {
                    ID = 1,
                    GameID = (Game)context.Games.Where(x => x.GameID == 1),
                    //GameID = 1,
                    CurrentGameSystem = GameSystem.NES
                },
                new GameGameSystemLink
                {
                    ID = 2,
                    GameID = (Game)context.Games.Where(x => x.GameID == 2),
                    //GameID = 2,
                    CurrentGameSystem = GameSystem.NES
                },
                new GameGameSystemLink
                {
                    ID = 3,
                    GameID = (Game)context.Games.Where(x => x.GameID == 3),
                    //GameID = 3,
                    CurrentGameSystem = GameSystem.Xbox
                },
                new GameGameSystemLink
                {
                    ID = 4,
                    GameID = (Game)context.Games.Where(x => x.GameID == 3),
                    //GameID = 3,
                    CurrentGameSystem = GameSystem.Xbox360
                });
        }
    }
}
