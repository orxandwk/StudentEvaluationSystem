﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentEvaluationSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentEvaluationSystemDBEntities : DbContext
    {
        public StudentEvaluationSystemDBEntities()
            : base("name=StudentEvaluationSystemDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Group_Schedule> Group_Schedule { get; set; }
        public virtual DbSet<Group_Types> Group_Types { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Mentor> Mentors { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Task_Types> Task_Types { get; set; }
    }
}
