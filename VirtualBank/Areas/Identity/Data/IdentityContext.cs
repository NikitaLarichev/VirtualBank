using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VirtualBank.Models;

namespace VirtualBank.Data;

public class IdentityContext : IdentityDbContext<IdentityUser>
{
    public IdentityContext()
    {
        Database.EnsureCreated();
    }
	public IdentityContext(DbContextOptions<IdentityContext> options)
        : base(options)
    {
    }
	public DbSet<Card> Cards { get; set; }
	protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
