using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreSendEmail.Models
{
    public class EfDbContext :DbContext
    {
        public EfDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<EmailSetting> EmailSettings { get; set; }
    }
}
