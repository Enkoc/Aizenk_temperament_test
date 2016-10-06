using Aizenk_temperament_test.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aizenk_temperament_test.Models
{
    public class TestDbContext : DbContext
    {
        public TestDbContext()
        {
            Database.SetInitializer(new QuestionDbInit());
        }
        public DbSet<Question> Questions { get; set; }
    }
}