using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.ProviderBase;
namespace Quan_Ly_HS_GV_THPT.HOCSINHDATA
{
    public class HOCSINHDATA:APP_DATA.DATA
    {
        public HOCSINHDATA()
        {
            base.path = "select *from HOCSINH ";
        }
        public void GAN_HS(List<String> HS)
        {
            cmd.Parameters.AddWithValue("@ID", HS[0]);
            cmd.Parameters.AddWithValue("@NAME", HS[1]);
            cmd.Parameters.AddWithValue("@CLASSID", HS[5]);
            DateTime a = Convert.ToDateTime(HS[3]);
            cmd.Parameters.AddWithValue("@DATE", a);
            cmd.Parameters.AddWithValue("@SEX", HS[3]);
            cmd.Parameters.AddWithValue("@DIACHI", HS[4]);
            
        }

        
}
