using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Models.Interfaces;

namespace Services
{
    public class LogService : IService<Log>
    {
        private IDataBase<Log> _db;
        public LogService(IDataBase<Log> db)
        {
            _db = db;
        }
        public bool AddLog(Log log)
        {
            bool completed = false;
            Log retVal = _db.Add(log);
            if (retVal != null && retVal.ID != null)
            {
                completed = true;
            }
            return completed;
        }

        public Log GetLog(Log log)
        {
            Log temp = _db.Get(log);
            return temp;
        }

        public List<Log>GetAllLogs()
        {
            List<Log> list = _db.GetAll();
            return list;
        }

        public Log RemoveLog(Log log)
        {
            Log temp = _db.Remove(log);
            return temp;
        }

        public Log UpdateLog(Log log)
        {
            Log temp = _db.Update(log);
            return temp;
        }
    }
}
