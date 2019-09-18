using KO.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.DAL
{
    public class KO_DBContext:DbContext
    {
        public KO_DBContext(DbContextOptions<KO_DBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamsOfMember> ExamsOfMembers { get; set; }
        public virtual DbSet<OptionsOfQuestion> OptionsOfQuestions { get; set; }
        public virtual DbSet<QuestionOfExam> QuestionOfExams { get; set; }
    }
}
