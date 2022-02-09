using System.ComponentModel.DataAnnotations.Schema;

namespace Source_code.Entitites
{
    [Table("Genders")]
    public  class Gender
    {
        #region Props
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
        public override string ToString()
        {
            var str = string.Empty;
            if (Name == "M")
                str = "Male";
            else if (Name == "F")
                str = "Female";
            else
                str = "Not declared";
            return str;
        }
    }
}
