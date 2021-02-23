using System;
using System.Collections.Generic;
using System.Linq;
using ToDoManager.Data;
using ToDoManager.Models;

namespace ToDoManager.Data
{
    public class Repository : IRepository
    {
        private List<ToDo> ToDoList;
        public Repository()
        {
            ToDoList= new List<ToDo>
            {
                new ToDo{Id = 1, Name = "Test", WhatToDo = "test todo lists can you see this?", IsCompleted = false, DateCreated = DateTime.Today },
                new ToDo{Id = 2, Name = "Test2", WhatToDo = "test todo lists can you edit this?", IsCompleted = false, DateCreated = DateTime.Today },
                new ToDo{Id = 3, Name = "aaaa", WhatToDo = "Use this to test search", IsCompleted = false, DateCreated = DateTime.Today },
                new ToDo{Id = 4, Name = "aaaa", WhatToDo = "Use this to test search", IsCompleted = false, DateCreated = DateTime.Today },
                new ToDo{Id = 5, Name = "aabb", WhatToDo = "Use this to test search", IsCompleted = false, DateCreated = DateTime.Today },
                new ToDo{Id = 6, Name = "aabc", WhatToDo = "Use this to test search", IsCompleted = false, DateCreated = DateTime.Today },
            };
        }

        public void Insert(ToDo toDo)
        {
            toDo.Id = ToDoList.Max(p => p.Id);
            ++toDo.Id;
            ToDoList.Add(toDo);
        }

        public void Update(ToDo toDo)
        {
            int index = ToDoList.FindIndex(p => p.Id == toDo.Id);
            ToDoList[index].Name = toDo.Name;
            ToDoList[index].WhatToDo = toDo.WhatToDo;
            ToDoList[index].IsCompleted = toDo.IsCompleted;
        }

        public List<ToDo> GetAll()
        {
            return ToDoList;
        }

        public ToDo GetItemById(int? id)
        {
            return ToDoList.SingleOrDefault(p => p.Id == id);
        }

        public void Remove(int id)
        {          
            ToDoList.Remove(GetItemById(id));
        }
    }
}
