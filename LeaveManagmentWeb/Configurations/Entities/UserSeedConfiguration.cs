using LeaveManagmentWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagmentWeb.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "72811880-5501-4468-bb0d-399e1ca1d9f4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Meriton1!"),
                    EmailConfirmed = true
                    
                },
                 new Employee
                 {
                     Id = "2aa5ba2b-9773-420c-8002-221b7a5733ad",
                     Email = "m.te@g.com",
                     NormalizedEmail = "M.TE@GMAIL.COM",
                     NormalizedUserName = "M.TE@GMAIL.COM",
                     UserName = "m.te@g.com",
                     FirstName = "System",
                     LastName = "User",
                     PasswordHash = hasher.HashPassword(null, "Meriton1!"),
                     EmailConfirmed=true
                 }
            );
        }
    }
}