using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Persistence.Configurations.Identity
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "363403d4-83e9-409a-bc50-2185af49968c",
                    UserId = "7426a8db-b16d-497d-bfa3-e0b29b6a0fec"

                },
                new IdentityUserRole<string>
                {
                    RoleId = "99254314-a271-47be-af1a-f1d78693731b",
                    UserId = "a50af610-518d-4f5f-8422-ea54c733771"

                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "2fdf6829-af22-41c3-83c8-b1681a8d0c98",
                     UserId = "56f97a8d-3571-4505-9f93-e2d6caed4525"

                 });
        }

    }
}
