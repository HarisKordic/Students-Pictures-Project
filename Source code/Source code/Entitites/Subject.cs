using System.ComponentModel.DataAnnotations.Schema;

namespace Source_code.Entitites
{
    [Table("Subjects")]
    public class Subject
    {
        #region Props
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
        public override string ToString()
        {
            return Name;
        }
    }
}
