using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source_code.Entitites
{
    [Table("Students")]
    public  class Student
    {
        #region Props

        public int Id { get; set; }
        public string Index { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public byte[] Picture { get; set; }
        public virtual Gender Gender { get; set; }
        public int Semester { get; set; }
        public string AcademicYear { get; set; }
        public string PhoneNumber { get; set; }
        public string Email => Name + "." + Surname + "@domain.com";
        [NotMapped] public string DateToShow => BirthDay.ShowDate();//So we can get the date in the DGV in the correct format;

        [NotMapped]
        public string StudentInfo => Name + " " + Surname + " born: " + DateToShow +
                                     " is currently in " + Semester + "  semester of the  academic " + AcademicYear +
                                     " year." + " Email: " + Email + ", Phone number: " + PhoneNumber
                                     + ", gender: " + Gender;//So we can have a string of information when we save a student to a file;
        [NotMapped] public List<StudentPicture> Pictures { get; set; }
        #endregion

        public Student()
        {
            Index = $"IN{(BirthDay.Year*100000)+new Random().Next(100,201)}";
            PhoneNumber=GeneratePhoneNumber();
            Pictures = new List<StudentPicture>();//So we don't get a null ref. exception;
        }
        public override string ToString() => Name + " " + Surname;
        #region Phone num generator

        private string GeneratePhoneNumber()
        {
            var number = string.Empty;
            var numbers = "0123456789";
            var rand = new Random();

            for (int i = 0; i <9; i++)
            {
                var index=rand.Next(0,numbers.Length);
                number += numbers[index];
            }
            return number;
        }
        #endregion
    }
    #region Extension class
    internal static class Extension
    {
        public static string ShowDate(this DateTime dateTime)
        {
            return dateTime.ToString("dd mm yyyy");
        }
    }
    #endregion
}
