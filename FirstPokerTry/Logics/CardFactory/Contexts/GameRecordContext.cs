#nullable disable

using System;
using Microsoft.EntityFrameworkCore;
using FirstPokerTry.Logics.CardFactory.Classes;

namespace FirstPokerTry.Logics.CardFactory.Contexts
{
    public class GameRecordContext : DbContext
    {
        //public GameRecordContext(DbContextOptions<GameRecordContext> options) : base(options) { }

        public DbSet<Player> Player => Set<Player>();
        public DbSet<Game> Game => Set<Game>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = ../../../FirstPokerTry/Data/Database/GameRecord.db");
        }
    }
}

