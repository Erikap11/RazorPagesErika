#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesErika.Models;

namespace RazorPagesErika.Data
{
    public class RazorPagesErikaContext : DbContext
    {
        public RazorPagesErikaContext (DbContextOptions<RazorPagesErikaContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesErika.Models.Book> Book { get; set; }
    }
}
