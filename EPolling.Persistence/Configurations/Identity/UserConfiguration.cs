using EPolling.Domain.Identity;
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
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hashers = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                new ApplicationUser
                {
                    Id = "7426a8db-b16d-497d-bfa3-e0b29b6a0fec",
                    Email = "test1@polling.com",
                    NormalizedEmail = "TEST1@POLLING.COM",
                    UserName = "test1",
                    NormalizedUserName = "TEST1",
                    PasswordHash = hashers.HashPassword(null, "P@ssword1"),
                },
                new ApplicationUser
                {
                    Id = "a50af610-518d-4f5f-8422-ea54c733771",
                    Email = "test2@polling.com",
                    NormalizedEmail = "TEST2@POLLING.COM",
                    UserName = "test2",
                    NormalizedUserName = "TEST2",
                    PasswordHash = hashers.HashPassword(null, "P@ssword2"),
                },
                new ApplicationUser
                {
                    Id = "56f97a8d-3571-4505-9f93-e2d6caed4525",
                    Email = "test3@polling.com",
                    NormalizedEmail = "TEST3@POLLING.COM",
                    UserName = "test3",
                    NormalizedUserName = "TEST3",
                    PasswordHash = hashers.HashPassword(null, "P@ssword3"),
                }
                ) ;
        }

    }
}
