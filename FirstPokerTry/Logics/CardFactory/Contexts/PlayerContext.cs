#nullable disable

using System;
using Microsoft.EntityFrameworkCore;
using FirstPokerTry.Logics.CardFactory.Classes;

namespace FirstPokerTry.Logics.CardFactory.Contexts
{
    public class PlayerContext : DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options) : base(options) { }

        public DbSet<Player> Player { get; set; }
    }
}

