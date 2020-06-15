using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartApi.Models
{
    public class Operator
    {
        #region Ctor
        public Operator()
        {

        }
        #endregion
        #region Props
        [Key]
        public int id { get; set; }
        [TypeConverter("NvarChar(50)"),Required]
        public string username { get; set; }
        [TypeConverter("NvarChar(50)"),Required]
        public string password { get; set; }
        [TypeConverter("NChar(14)"),Required]
        public string mobile { get; set; }
        [TypeConverter("nchar(50)"),Required]
        public string accessible { get; set; }

        #endregion
        #region Relations

        #endregion
    }
}
