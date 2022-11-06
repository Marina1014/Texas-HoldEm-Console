#nullable disable

using System;
using Microsoft.EntityFrameworkCore;
using FirstPokerTry.Logics.CardFactory.Classes;

namespace FirstPokerTry.Logics.CardFactory.Contexts
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
    }
}

