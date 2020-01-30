﻿using CS321_W3D1_ToDoAPI_EF.Models;
using System.Collections.Generic;

namespace CS321_W3D1_ToDoAPI_EF.Services
{
    public interface IToDoService
    {
        // CRUDL - create (add), read (get), update, delete (remove), list

        // create
        ToDo Add(ToDo todo);

        // read
        ToDo Get(int id);

        // update
        ToDo Update(ToDo todo);

        // delete
        void Remove(ToDo todo);

        // list
        IEnumerable<ToDo> GetAll();
    }
}