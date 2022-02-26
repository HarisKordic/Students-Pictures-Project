using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Source_code.Entitites
{
    [Table("StudentsPassedSubjects")]
    public class StudentPassedSubject
    {
        #region Props

        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }
        [NotMapped] public string DateToShow => Date.ShowDate();//Just to show date in correct format in dgv;
        #endregion  
        public override string ToString()
        {
            return $"Student: {Student} has passed the subject: {Subject} with {Grade}/10 grade!";
        }
    }
}
