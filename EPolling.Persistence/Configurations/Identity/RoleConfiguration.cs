using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPolling.Persistence.Configurations.Identity
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "363403d4-83e9-409a-bc50-2185af49968c",
                    Name = "High",
                    NormalizedName = "HIGH"
                },
                new IdentityRole
                {
                    Id = "99254314-a271-47be-af1a-f1d78693731b",
                    Name = "Medium",
                    NormalizedName = "MEDIUM"
                },
                new IdentityRole
                {
                    Id = "2fdf6829-af22-41c3-83c8-b1681a8d0c98",
                    Name = "Low",
                    NormalizedName = "LOW"
                }
                );

        }
    }
}
