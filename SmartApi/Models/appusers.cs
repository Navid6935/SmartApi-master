using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartApi.Models
{
    public class appusers
    {
        #region Ctor
        public appusers()
        {

        }
        #endregion
        #region Props
        [Key]
        public int id { get; set; }
        [TypeConverter("NvarChar(250)"), Required]
        public string username { get; set; }
        [TypeConverter("NvarChar(250)"), Required]
        public string password { get; set; }
        [TypeConverter("NvarChar(250)"), Required]
        public string fullname { get; set; }
        public int state { get; set; }
        public int city { get; set; }
        [TypeConverter("NvarChar(200)"), Required]
        public string mob { get; set; }
        [TypeConverter("NvarChar(250)"), Required]
        public string email { get; set; }
        [TypeConverter("nchar(11)"), Required]
        public string savedate { get; set; }
        [TypeConverter("nchar(11)"), Required]
        public string savetime { get; set; }
        [TypeConverter("nchar(4)"), Required]
        public string year { get; set; }
        [TypeConverter("nchar(4)"), Required]
        public string month { get; set; }
        [TypeConverter("nchar(4)"), Required]
        public string day { get; set; }
        public Boolean confirm { get; set; }
        public int numberdevices { get; set; }
        [TypeConverter("nchar10)"), Required]
        public string locationx { get; set; }
        [TypeConverter("nchar(10)"), Required]
        public string locationy { get; set; }
        public Boolean active { get; set; }
        public int  country { get; set; }
        public int  forgetpassword { get; set; }
        public decimal  forgetpassworddatetime { get; set; }

        #endregion
        #region Relations

        #endregion


    }
}
