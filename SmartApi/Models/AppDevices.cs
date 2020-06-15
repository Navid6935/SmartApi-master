using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartApi.Models
{
    public class AppDevices
    {
        #region Ctor
        public AppDevices()
        {

        }
        #endregion
        #region props
        [Key]

        public int id { get; set; }
        [TypeConverter("NvarChar(200)"), Required]
        public string imei { get; set; }
        [TypeConverter("NvarChar(200)"), Required]
        public string serial { get; set; }
        [TypeConverter("NvarChar(250)"), Required]
        public string username { get; set; }
        [TypeConverter("NvarChar(150)"), Required]
        public string devicename { get; set; }
        [TypeConverter("NChar(2)"), Required]
        public string vaziat { get; set; }

        [TypeConverter("NChar(10)"), Required]
        public string savetiime { get; set; }

        [TypeConverter("NChar(10)"), Required]
        public string savedate { get; set; }
        [TypeConverter("NChar(10)"), Required]
        public string type { get; set; }

        #endregion
        #region Relation

        #endregion
    }
}
