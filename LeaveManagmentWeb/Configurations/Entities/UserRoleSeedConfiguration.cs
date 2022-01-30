using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagmentWeb.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2bb5ab2b-9773-420c-8002-221b7a5733bb",
                    UserId = "72811880-5501-4468-bb0d-399e1ca1d9f4"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "2bb5af7b-7b73-42c-8002-471b7a5733bc",
                    UserId = "2aa5ba2b-9773-420c-8002-221b7a5733ad"
                }
            );
        }
    }
}