using DataBaseLayer;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoggingC
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void AddLog(object sender, EventArgs e)
        {
            var msg = message.Value;
            var sev = 0;
            int.TryParse(severity.Value,out sev);
            Log log = new Log(msg, sev);
            var service = new LogService(new LogDB());
            service.AddLog(log);
        }

        protected void GetLastLog(object sender, EventArgs e)
        {
            var service = new LogService(new LogDB());
            var list = service.GetAllLogs();
            var last = list.LastOrDefault();
            if (last != null)
            {
                refMessage.Value = last.Message;
                refSeverity.Value = last.Severity.ToString();
            }
        }

    }
}