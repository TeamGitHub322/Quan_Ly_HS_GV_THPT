using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace Quan_Ly_HS_GV_THPT.APP_DATA
{
   public class Connector
    {
       public Connector() { }
       public String getconnect()
       {
           return (ConfigurationManager.ConnectionStrings["Conn"].ToString());
       }
    }
}
