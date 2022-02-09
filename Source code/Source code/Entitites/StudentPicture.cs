﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source_code.Entitites
{
    [Table("StudentsPictures")]
    public  class StudentPicture
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