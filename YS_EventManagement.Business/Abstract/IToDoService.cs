﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YS_EventManagement.Entities;

namespace YS_EventManagement.Business.Abstract
{
    public interface IToDoService
    {
        Task<List<ToDo>> GetAllToDos();

        Task<ToDo> GetToDoById(int id);
        Task<ToDo> GetToDoByName(string name);
        Task<ToDo> CreateToDo(ToDo todo);
        Task<ToDo> UpdateToDo(ToDo todo);
        Task DeleteToDo(int id);
    }
}
