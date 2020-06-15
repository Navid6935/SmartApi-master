using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartApi.Models
{
    public class AppUpdate
    {
        #region Ctor
        public AppUpdate()
        {

        }
        #endregion
        #region Props
        [Key]
        public int id { get; set; }
        [TypeConverter("bigint")]
        public string appver { get; set; }
        [TypeConverter("nchar(30)")]
        public string applink { get; set; }
        [TypeConverter("nchar(10)"), Required]
        public string appmode { get; set; }
        #endregion
        #region Relations

        #endregion


    }
}
