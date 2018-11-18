using Microsoft.EntityFrameworkCore;
using QTApi.Models.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTApi.DAL
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {

        }

        public DbSet<CatFact> CatFacts { get; set; }
        public DbSet<SlothFact> SlothFacts { get; set; }
        public DbSet<CowFact> CowFacts { get; set; }
        public DbSet<ElephantFact> ElephantFacts { get; set; }
        public DbSet<CrowFact> CrowFacts { get; set; }
        public DbSet<JellyfishFact> JellyfishFacts { get; set; }
        public DbSet<MantisShrimpFact> MantisShrimpFacts { get; set; }
        public DbSet<DogFact> DogFacts { get; set; }
    }
}
