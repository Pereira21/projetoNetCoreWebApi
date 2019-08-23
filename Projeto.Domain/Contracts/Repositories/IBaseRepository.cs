﻿using System.Collections.Generic;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IBaseRepository<T>
        where T : class
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);

        List<T> SelectAll();
        T SelectById(int id);
    }
}
