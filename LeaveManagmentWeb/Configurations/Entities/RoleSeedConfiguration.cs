using LeaveManagmentWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagmentWeb.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "2bb5ab2b-9773-420c-8002-221b7a5733bb",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "2bb5af7b-7b73-42c-8002-471b7a5733bc",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
            ) ;
        }
    }
}