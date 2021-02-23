using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoManager.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WhatToDo { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
