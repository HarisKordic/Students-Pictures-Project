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
        public string Email => Name + "." + Surname + "@somedomain.com";

        #endregion

        public Student()
        {
            Index = $"IN{(BirthDay.Year*100000)+new Random().Next(100,201)}";
            PhoneNumber=GeneratePhoneNumber();
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
}
