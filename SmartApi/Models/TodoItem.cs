using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartApi.Models
{
    public class TodoItem
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public Boolean IsComplete { get; set; }
    }
}
