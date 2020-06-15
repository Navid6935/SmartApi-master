using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartApi.Models
{
    public class StoredSerials
    {
        #region Ctor
        public StoredSerials()
        {

        }
        #endregion
        #region Props
        [Key]
        public int id { get; set; }
        [TypeConverter("NvarChar(200)"),Required]
        public string Serial { get; set; }
        [TypeConverter("NChar(2)"), Required]
        public string vaziat { get; set; }
        [TypeConverter("NChar(10)"), Required]
        public string savetime { get; set; }
        [TypeConverter("NChar(10)"), Required]
        public string savedate { get; set; }
        [TypeConverter("NChar(10)"), Required]
        public string savefrom { get; set; }
        public int numberofapp { get; set; }
        public Boolean dataread { get; set; }
        public int intervalsec { get; set; }
        #endregion
        #region Relations

        #endregion
    }
}
