using CringeProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CringeProject.Repository
{
    class SectionPapersContext : DbContext
    {
        public DbSet<Section> Sections { get; set; }
        public DbSet<Paper> Papers { get; set; }
    }
}
