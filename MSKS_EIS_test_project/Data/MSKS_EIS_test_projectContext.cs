using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MSKS_EIS_test_project.Models;

namespace MSKS_EIS_test_project.Data
{
    public class MSKS_EIS_test_projectContext : DbContext
    {
        public MSKS_EIS_test_projectContext (DbContextOptions<MSKS_EIS_test_projectContext> options)
            : base(options)
        {
        }

        public DbSet<MSKS_EIS_test_project.Models.User> User { get; set; } = default!;
    }
}
