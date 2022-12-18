using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Models;

namespace Users.Contexts
{
    public class DefaultContext : DbContext
    {
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }
    }
}
