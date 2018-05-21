using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Exam.Models
{
    public class dbContext:DbContext

    {
        public dbContext() : base("DB")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}