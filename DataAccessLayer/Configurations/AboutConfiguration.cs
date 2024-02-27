using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
    public class AboutConfiguration : IEntityTypeConfiguration<AboutDto>
    {
        public void Configure(EntityTypeBuilder<AboutDto> builder)
        {
            builder.Property(x=>x.Description).HasMaxLength(50);
        }
    }
}
