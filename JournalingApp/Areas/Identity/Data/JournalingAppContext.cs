using JournalingApp.Areas.Identity.Data;
using JournalingApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace JournalingApp.Data;

public class JournalingAppContext : IdentityDbContext<JournalingAppUser>
{
    public JournalingAppContext(DbContextOptions<JournalingAppContext> options)
        : base(options)
    {
       

}
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
        protected DbSet<Blogs> Blogs { get; set; } = default!;
        protected DbSet<Journals> Journals { get; set; } = default!;

}
    

    // Customize the ASP.NET Identity model and override the defaults if needed.
    // For example, you can rename the ASP.NET Identity table names and more.
    // Add your customizations after calling base.OnModelCreating(builder);


