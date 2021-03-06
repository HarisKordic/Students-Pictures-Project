using Source_code.Entitites;
using System.Data.Entity;

namespace Source_code.DataBase
{
    public class ConnectionToDb : DbContext
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
        public DbSet<StudentPassedSubject> StudentsPassedSubjects { get; set; }
        public DbSet<StudentPicture> StudentsPictures { get; set; }
        #endregion
    }
}
