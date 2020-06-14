using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace SmartApi.Models
{
    public class TodoRepository : ITodoRepository
    {
        //Create db
        private static ConcurrentDictionary<string, TodoItem> _Todos = new ConcurrentDictionary<string, TodoItem>();
        public TodoRepository()
        {
            Add(new Models.TodoItem { Name = "First" });
        }
        public void Add(TodoItem item)
        {
            item.Key = Guid.NewGuid().ToString();
        }
        public void Update(TodoItem item)
        {
            _Todos[item.Key] = item;
        }
        public TodoItem Find(string Key)
        {
            TodoItem item;
            //Method in Cores
            _Todos.TryGetValue(Key, out item);
            return item;
        }


        public TodoItem Remove(string Key)
        {
            TodoItem item;
            //Method in Cores
            _Todos.TryRemove(Key, out item);
            return item;
        }
        public IEnumerable<TodoItem> GetAll()
        {
            return _Todos.Values;  
        }


    }
}
