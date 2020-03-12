
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebCoreApi.Domain.Entities.Catalog;

namespace WebCoreApi.Data.Context
{
    public class WareHouseDbContext:IdentityDbContext
    {
        
        public WareHouseDbContext(DbContextOptions<WareHouseDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.HasDefaultSchema(schemeName);
            //var entities = builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys());
            //foreach (var relationship in entities)
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //
            //builder.HasDefaultSchema(schemeName);

            //builder.Entity<User>(b =>
            //{
            //    b.HasKey(u => u.Id);
            //    b.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            //    b.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");
            //    b.ToTable(name: "Users");
            //    b.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
            //    b.Property(u => u.UserName).HasMaxLength(256);
            //    b.Property(u => u.NormalizedUserName).HasMaxLength(256);
            //    b.Property(u => u.Email).HasMaxLength(256);
            //    b.Property(u => u.NormalizedEmail).HasMaxLength(256);
            //    b.HasMany<UserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();
            //    b.HasMany<UserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();
            //    b.HasMany<UserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();
            //    b.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
            //});

            //builder.Entity<UserClaim>(b =>
            //{
            //    b.HasKey(uc => uc.Id);
            //    b.ToTable("UserClaims");
            //});

            //builder.Entity<UserLogin>(b =>
            //{
            //    b.HasKey(l => new { l.LoginProvider, l.ProviderKey });
            //    b.Property(l => l.LoginProvider).HasMaxLength(128);
            //    b.Property(l => l.ProviderKey).HasMaxLength(128);
            //    b.ToTable("UserLogins");
            //});

            //builder.Entity<UserToken>(b =>
            //{
            //    b.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });
            //    b.Property(t => t.LoginProvider).HasMaxLength(256);
            //    b.Property(t => t.Name).HasMaxLength(256);
            //    b.ToTable("UserTokens");
            //});

            //builder.Entity<Role>(b =>
            //{
            //    b.HasKey(r => r.Id);
            //    b.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();
            //    b.ToTable("Roles");
            //    b.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();
            //    b.Property(u => u.Name).HasMaxLength(256);
            //    b.Property(u => u.NormalizedName).HasMaxLength(256);
            //    b.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();
            //    b.HasMany<RoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();
            //});

            //builder.Entity<RoleClaim>(b =>
            //{
            //    b.HasKey(rc => rc.Id);
            //    b.ToTable("RoleClaims");
            //});

            //builder.Entity<UserRole>(b =>
            //{
            //    b.HasKey(r => new { r.UserId, r.RoleId });
            //    b.ToTable("UserRoles");
            //});
        }
        public DbSet<Product> Product { get; set; }
    }
}
