using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiAssistant.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiAssistant.Repository.Seeds
{
    public class ErrorCategorySeed : IEntityTypeConfiguration<ErrorCategory>
    {
        public void Configure(EntityTypeBuilder<ErrorCategory> builder)
        {
            builder.HasData(new List<ErrorCategory>
            {
                new ErrorCategory
                {
                    Id = 1,
                    Name = "Yazılımsal",
                },
                new ErrorCategory
                {
                    Id = 2,
                    Name = "Donanımsal",
                },
                new ErrorCategory
                {
                    Id = 3,
                    Name = "Ağ",
                }
            });
        }
    }
}