using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Teatra.Data
{
    public class ApplicationDbContext : IdentityDbContext<Users>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Performances> Performances { get; set; }
        public DbSet<RequestsForCourse> RequestsForCourse { get; set; }
        public DbSet<RequestsForTicket> RequestsForTicket { get; set; }
    }
}
