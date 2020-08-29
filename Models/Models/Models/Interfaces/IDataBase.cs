using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public interface IDataBase<T>
    {
        T Add(T obj);
        T Remove(T obj);
        T Get(T obj);
        List<T> GetAll();
        T Update(T obj);
    }
}
