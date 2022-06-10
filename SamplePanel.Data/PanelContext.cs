using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePanel.Data
{
   
    public class PanelContext : DbContext
    {
        public PanelContext(DbContextOptions<PanelContext> options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = developer; Database = SamplePanel; Persist Security Info = True; User ID = sa; Password = 123456");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roles>().HasData(new Roles[]
            {
                new Roles{ID=1, RoleName ="Admin",RoleTitle="مدیر سیستم",CreateDate=DateTime.Now.Date,IsDeleted=false},
                new Roles{ID=2,RoleName="User",RoleTitle="کاربر عادی",CreateDate=DateTime.Now.Date,IsDeleted=false}
            });

            modelBuilder.Entity<Users>().HasData(new Users
            {
                ID=Guid.NewGuid(),
                Active=true,
                Email="m.qomi97@gmail.com",
                PhoneNumber="+989127348785",
                FName="محمد رضا",
                UserName="Admin",
                Pass="123456",
                LName="قمی",
                RoleID=1              
            });           
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role_Permission> Role_Permission { get; set; }
    }
}
