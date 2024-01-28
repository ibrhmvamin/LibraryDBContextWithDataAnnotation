using EFTask2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask2.Contexts
{
    
    public class LibraryDBContext2:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConStr = "Data Source=LAPTOP-46JAQGOF\\SQLEXPRESS;" +
           "Initial Catalog=LibraryDBContext2;Integrated Security=True;" +
           "Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;" +
           "Application Intent=ReadWrite;" +
           "Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(ConStr);
            base.OnConfiguring(optionsBuilder);    
        }

        public DbSet<Curator> curators { get; set; }
        public DbSet<Department> departments { get; set; }

        public DbSet<Faculty> faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupsCurators> GroupsCurators { get; set; }
        public DbSet<GroupsLectures> GroupsLectures { get; set; }
        public DbSet<GroupsStudents> GroupsStudents { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
