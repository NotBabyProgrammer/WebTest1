using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebTest1.Models;

namespace WebTest1.Data
{
    public class WebTest1Context : DbContext
    {
        public WebTest1Context (DbContextOptions<WebTest1Context> options)
            : base(options)
        {
        }

        public DbSet<WebTest1.Models.Students> Students { get; set; } = default!;
    }
}
