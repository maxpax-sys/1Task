using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Task1_1.Models
{
    public class AnswersContext : DbContext
    { public DbSet<GuestResponse> GuestResponses { get; set; }
        public AnswersContext(DbContextOptions<AnswersContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
 
}
    
}
