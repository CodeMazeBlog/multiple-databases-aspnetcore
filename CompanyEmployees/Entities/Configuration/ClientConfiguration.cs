using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasData
            (
                new Client
                {
                    Id = new Guid("c1f33503-bb38-4fa1-98a0-6cfaf9986797"),
                    Name = "External Client's Test Name"
                }
            );
        }
    }
}
