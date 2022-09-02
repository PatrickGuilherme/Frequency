using Frequency.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequency.Persistence.Context
{
    public class DataContext : DbContext
    {
        public DbSet<TimeRegister> DB_TimeRegister { get; set; }
        public DbSet<User> DB_User { get; set; }
        public DbSet<UserToTimeRegister> DB_UserToTimeRegister { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        private static void ModelCreateUser(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("User");
            builder.Entity<User>().Property(p => p.ID).HasColumnName("ID");
            builder.Entity<User>().HasKey(p => p.ID);
            builder.Entity<User>().Property(p => p.ID).IsRequired();

            builder.Entity<User>().Property(p => p.Email).HasColumnName("Email");
            builder.Entity<User>().Property(p => p.Email).IsRequired();
            builder.Entity<User>().Property(p => p.Email).HasMaxLength(200);

            builder.Entity<User>().Property(p => p.Password).HasColumnName("Password");
            builder.Entity<User>().Property(p => p.Password).IsRequired();
            builder.Entity<User>().Property(p => p.Password).HasMaxLength(8);
        }

        private static void ModelCreateTimeRegister(ModelBuilder builder)
        {
            builder.Entity<TimeRegister>().ToTable("TimeRegister");
            builder.Entity<TimeRegister>().Property(p => p.ID).HasColumnName("ID");
            builder.Entity<TimeRegister>().HasKey(p => p.ID);
            builder.Entity<TimeRegister>().Property(p => p.ID).IsRequired();

            builder.Entity<TimeRegister>().Property(p => p.InputTime).HasColumnName("InputTime");
            builder.Entity<TimeRegister>().Property(p => p.InputTime).IsRequired();

            builder.Entity<TimeRegister>().Property(p => p.OutputTime).HasColumnName("OutputTime");
            builder.Entity<TimeRegister>().Property(p => p.OutputTime).IsRequired();

            builder.Entity<TimeRegister>().Property(p => p.InputBreaktTime).HasColumnName("InputBreaktTime");
            builder.Entity<TimeRegister>().Property(p => p.InputBreaktTime).IsRequired(false);

            builder.Entity<TimeRegister>().Property(p => p.OutputBreakTime).HasColumnName("OutputBreakTime");
            builder.Entity<TimeRegister>().Property(p => p.OutputBreakTime).IsRequired(false);

            builder.Entity<TimeRegister>().Property(p => p.Shift).HasColumnName("Shift");
            builder.Entity<TimeRegister>().Property(p => p.Shift).IsRequired();

            builder.Entity<TimeRegister>().Property(p => p.PendingTime).HasColumnName("PendingTime");
            builder.Entity<TimeRegister>().Property(p => p.PendingTime).IsRequired();

            builder.Entity<TimeRegister>().Property(p => p.ExtraTime).HasColumnName("ExtraTime");
            builder.Entity<TimeRegister>().Property(p => p.ExtraTime).IsRequired();

            builder.Entity<TimeRegister>().Property(p => p.DateRegister).HasColumnName("DateRegister");
            builder.Entity<TimeRegister>().Property(p => p.DateRegister).IsRequired();
        }

        private static void ModelCreateUserToTimeRegister(ModelBuilder builder)
        {
            builder.Entity<UserToTimeRegister>().ToTable("UserToTimeRegister");
            builder.Entity<UserToTimeRegister>().Property(p => p.ID_TimeRegister).HasColumnName("ID_TimeRegister");
            builder.Entity<UserToTimeRegister>().Property(p => p.ID_TimeRegister).IsRequired();

            builder.Entity<UserToTimeRegister>().Property(p => p.ID_User).HasColumnName("ID_User");
            builder.Entity<UserToTimeRegister>().Property(p => p.ID_User).IsRequired();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            ModelCreateUser(builder);
            ModelCreateTimeRegister(builder);
            ModelCreateUserToTimeRegister(builder);
        }
    }
}
