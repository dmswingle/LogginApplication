using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public class IService<T>
    {
        IDataBase<T> _db;        
    }
}
