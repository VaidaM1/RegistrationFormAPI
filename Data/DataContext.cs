using Microsoft.EntityFrameworkCore;
using RegistrationFormAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<DropDownOption> DropDownOptions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<SelectedValue> SelectedValues { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SelectedValue>()
            .HasKey(bc => new { bc.QuestionId, bc.DropDownOptionId });
 
        }

    }
}
