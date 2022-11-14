#nullable disable

using System;
using Microsoft.EntityFrameworkCore;
using FirstPokerTry.Logics.CardFactory.Classes;

namespace FirstPokerTry.Logics.CardFactory.Contexts
{
    public class GameRecordContext : DbContext
    {
        //public GameRecordContext(DbContextOptions<GameRecordContext> options) : base(options) { }
        public DbSet<Player> Players => Set<Player>();
        public DbSet<Game> Games => Set<Game>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=/Data/Database/GameRecord.db");
        }
    }
}

