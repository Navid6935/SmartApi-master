using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartApi.Models
{
    public class UsersRepository : ITodoRepository
    {
        public void Add(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public TodoItem Find(string Key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public TodoItem Remove(string Key)
        {
            throw new NotImplementedException();
        }

        public void Update(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
