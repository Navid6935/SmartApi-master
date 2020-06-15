using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartApi.Models
{
    public class EsSerialActive
    {
        #region Ctor
        public EsSerialActive()
        {

        }
        #endregion
        #region Props
        [Key]
        public int id { get; set; }
        [TypeConverter("NvarChar(50)")]
        public string username { get; set; }
        [TypeConverter("NvarChar(50)")]
        public string serial { get; set; }
        [TypeConverter("NvarChar(50)")]
        public string qr { get; set; }
        [TypeConverter("NChar(10)")]
        public string savedate { get; set; }
        [TypeConverter("NChar(10)")]
        public string savetime { get; set; }
        #endregion
        #region Relations

        #endregion
    }
}
