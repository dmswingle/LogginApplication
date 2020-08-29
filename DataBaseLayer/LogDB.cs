using Models;
using Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace DataBaseLayer
{
    public class LogDB : IDataBase<Log>
    {

        private static List<Log> list = new List<Log>();

        public Log Add(Log obj)
        {
            if (obj.ID == null)
            {
                obj.ID = GetId();
            }
            if (list.Contains(obj)) 
            { 
                throw new Exception("Log is already created"); 
            };
            list.Add(obj);
            return obj;

        }

        public Log Get(Log obj)
        {
            if(obj.ID == null) { throw new Exception("ID cannot be null."); }
            List<Log> list = GetAll();
            Log temp = list.Where(x => x.ID == obj.ID).FirstOrDefault();
            return temp;
        }

        public List<Log> GetAll()
        {
            return list.OrderBy(x => x.ID).ToList();
        }

        public Log Remove(Log obj)
        {
            var log = list.Where(x => x.ID == obj.ID).FirstOrDefault();
            list.Remove(log);
            return log;
        }

        public Log Update(Log obj)
        {
            Log log = list.Where(x => x.ID == obj.ID).FirstOrDefault();
            if(log != null)
            {
                list.Remove(log);
                list.Add(obj);
                list = list.OrderBy(x => x.ID).ToList();
            }
            return obj;
        }

        private int GetId()
        {
            int id = 1;
            List<Log> list = GetAll();
            int? temp = list.Select(x => x.ID).Max();
            if (temp != null) id = (int)temp + 1;
            return id;
        }

    }
}
