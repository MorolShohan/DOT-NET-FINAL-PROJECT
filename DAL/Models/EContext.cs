﻿using System.Data.Entity;

namespace DAL.Models
{
    internal class EContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Token> Tokens { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Order> Orders { get; set; }


        public DbSet<Student> Students { get; set; }

        public DbSet<StudentMgs> StudentMgses { get; set; }

        public DbSet<StudentComment> StudentComments { get; set; }

        public DbSet<StudentPost> StudentPosts { get; set; }
    }

}
