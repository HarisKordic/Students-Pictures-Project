using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Source_code.Entitites
{
    [Table("StudentsPictures")]
    public class StudentPicture
    {
        #region Props
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        #endregion
    }
}
