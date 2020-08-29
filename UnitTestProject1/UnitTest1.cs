using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Models.Interfaces;
using Services;
using DataBaseLayer;
using System.Collections.Generic;
using System;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod("Logs Created")]
        public void LogsCreated()
        {
            LogService service = new LogService(new LogDB());
            Log testLog = new Log("Test Log 1", 1);
            Assert.IsTrue(testLog.ID == null, "The ID is not null when created");
            bool added = service.AddLog(testLog);
            Assert.IsTrue(added, "The return value from AddLog is false");
            List<Log> list = service.GetAllLogs();
            Log log1 = list.FirstOrDefault();
            Assert.AreEqual(1, log1.ID, "ID is not 1");
            Assert.AreEqual("Test Log 1", log1.Message, true);

            Log testLog2 = new Log("Test Log 2", 1);
            Assert.IsTrue(testLog2.ID == null, "The ID is not null when created");
            bool added2 = service.AddLog(testLog2);
            Assert.IsTrue(added2, "The return value from AddLog is false");
            list = service.GetAllLogs();
            Log log2 = list.Skip(1).FirstOrDefault();
            Assert.AreEqual(2, log2.ID, "ID is not 2");
            Assert.AreEqual("Test Log 2", log2.Message, true);

        }
        [TestMethod("Log Updated")]
        public void LogUpdated()
        {
            Log testLog = new Log("Pre update", 1);
            LogService service = new LogService(new LogDB());
            Assert.IsTrue(testLog.ID == null, "The ID is not null when created");
            bool added = service.AddLog(testLog);
            Assert.IsTrue(added, "The return value from AddLog is false");
            List<Log> list = service.GetAllLogs();
            Log log1 = list.FirstOrDefault();
            Assert.AreEqual(1, log1.ID, "ID is not 1");
            Assert.AreEqual("Pre update", log1.Message, true);

            log1.Message = "Post update";
            log1.Severity = 2;
            Log updated = service.UpdateLog(log1);
            list = service.GetAllLogs();
            Log temp = list.FirstOrDefault();
            Assert.AreEqual(log1.ID, temp.ID, "ID's do not match");
            Assert.AreEqual("Post update", temp.Message, true);
        }
    }
}
