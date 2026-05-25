using Microsoft.EntityFrameworkCore;

public class RpgContext : DbContext
{
    public DbSet<Personagem> Personagens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=rpg.db");
    }
}