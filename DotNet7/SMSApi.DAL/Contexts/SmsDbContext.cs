global using SMSApi.DAL.Entities;
global using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace SMSApi.DAL.Contexts
{
    public class SmsDbContext : IdentityDbContext<IdentityUser>
    {
        public SmsDbContext(DbContextOptions<SmsDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
