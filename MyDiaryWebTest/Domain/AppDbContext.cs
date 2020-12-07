using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyDiaryWebTest.Domain.Entities;

namespace MyDiaryWebTest.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "8af10568-b018-4fe7-a380-7d6a14c70b74",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "polcraz",
                NormalizedUserName = "POLCRAZ",
                Email = "polcrazpolcraz@gmail.com",
                NormalizedEmail = "POLCRAZPOLCRAZ@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "trashbox123"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "8af10568-b018-4fe7-a380-7d6a14c70b74",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

            modelBuilder.Entity<Note>().HasData(new Note
            {
                Id = Guid.Parse("150e2590-46b4-4ee9-8256-1b4b84dbc670"),
                Text = "TestNoteText",
                Title = "TestNoteTitle",
                UserId = Guid.Parse("82dad1b6-5b56-4fad-8892-b9d9026d510e")
            });

            modelBuilder.Entity<Note>().HasData(new Note
            {
                Id = Guid.Parse("154d9d96-7f2b-400e-a309-e4168af164d5"),
                Text = "TestNoteText2",
                Title = "TestNoteTitle2",
                UserId = Guid.Parse("82dad1b6-5b56-4fad-8892-b9d9026d510e")
            });

            modelBuilder.Entity<Note>().HasData(new Note
            {
                Id = Guid.Parse("b78367f1-c042-4ce6-9bd7-234f880ab1df"),
                Text = "TestNoteText3",
                Title = "TestNoteTitle3",
                UserId = Guid.Parse("82dad1b6-5b56-4fad-8892-b9d9026d510e")
            });
        }
    }
}
