﻿using System.Collections.Generic;

namespace Net6Data;
public interface IRepository<T>
    {
        IEnumerable<T> GetLists();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
