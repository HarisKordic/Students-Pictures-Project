using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source_code.Entitites;

namespace Source_code.DataBase
{
    public  class ConnectionToDb:DbContext
    {
        #region Connection to DB
        public ConnectionToDb() : base("DataBasePath")
        {

        }
        #endregion

        #region Tables
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentPassedSubject> StudentPassedSubjects { get; set; }
        #endregion
    }
}
