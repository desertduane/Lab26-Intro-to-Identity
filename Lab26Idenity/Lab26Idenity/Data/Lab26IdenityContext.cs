using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab26Idenity.Models
{
    public class Lab26IdenityContext : DbContext
    {
        public Lab26IdenityContext (DbContextOptions<Lab26IdenityContext> options)
            : base(options)
        {
        }

        public DbSet<Lab26Idenity.Models.CMS> CMS { get; set; }
    }
}
