using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartApi.Models
{
    public class Category
    {
        #region Ctor
        public Category()
        {

        }
        #endregion
        #region Props
        [Key]
        public int id { get; set; }
        [TypeConverter("NChar(30)"), Required]
        public string category { get; set; }
        [TypeConverter("NChar(20)"), Required]
        public string serial { get; set; }

        #endregion
        #region Relations

        #endregion
    }
}
