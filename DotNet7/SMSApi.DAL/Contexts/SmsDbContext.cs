global using SMSApi.DAL.Entities;
global using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApi.DAL.Contexts
{
    public class SmsDbContext : DbContext
    {
        public SmsDbContext(DbContextOptions<SmsDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
