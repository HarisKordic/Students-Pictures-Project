using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source_code.Entitites
{
    [Table("Subjects")]
    public  class Subject
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
