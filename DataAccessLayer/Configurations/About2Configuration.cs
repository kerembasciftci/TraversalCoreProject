using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
    public class About2Configuration : IEntityTypeConfiguration<About2Dto>
    {
        public void Configure(EntityTypeBuilder<About2Dto> builder)
        {
            
        }
    }
}
