using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using Quan_Ly_HS_GV_THPT.APP_DATA;
using System.Windows.Forms;

namespace Quan_Ly_HS_GV_THPT.GIAOVIENDATA
{
     public class GIAOVIENDATA : DATA
     {
          public GIAOVIENDATA()
          {
               base.path = "select * from GIAOVIEN ";
          }
          public void GAN_GV(List<String> GV)
          {
               cmd.Parameters.AddWithValue("@ID", GV[0]);
               cmd.Parameters.AddWithValue("@NAME", GV[1]);
               cmd.Parameters.AddWithValue("@SDT", GV[2]);
               cmd.Parameters.AddWithValue("@EMAIL", GV[3]);
               cmd.Parameters.AddWithValue("@SEX", GV[4]);
               cmd.Parameters.AddWithValue("@HOCHAM", GV[5]);
               cmd.Parameters.AddWithValue("@HOCVI", GV[6]);
               DateTime a = Convert.ToDateTime(GV[7]);
               cmd.Parameters.AddWithValue("@DATE", a);
          }

          public void InsertGV(List<string> GV)
          {
               //CHECK = 0;
               //base.sql = "INSERTGIAOVIEN";
               //SP_DATA();
               //GAN_GV(GV);
               //check();
               SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-6DIRH3U\SQLEXPRESS02;Initial Catalog=QL_HOCSINH_GIAOVIEN;user id=sa;password=123456;Integrated Security=True");               
               SqlDataAdapter da = new SqlDataAdapter(cmd);//lưu dữ liệu lấy được vào đây
               //string sSql = "INSERT INTO GiaoVien VALUES (ID_GiaoVien='"+GV[0]+"',TenGV='" + GV[1] + "',SDT=" + GV[2] + ",Email='" + GV[3] + "',GT='" + GV[4] + "',HocHam='" + GV[5] + "',HocVi='" + GV[6]="')";
               string sSql = "INSERT INTO GiaoVien VALUES ('"+GV[0]+ "','" + GV[1] + "'," + GV[2] + ",'" + GV[3] + "','" + GV[4] + "','" + GV[5] + "','" + GV[6] + "')";

               da.InsertCommand = new SqlCommand(sSql, connect);
               connect.Open();
               da.InsertCommand.ExecuteNonQuery();
               connect.Close();
               MessageBox.Show("Thêm giáo viên"+GV[0]+" thành công");
          }
        public void UpdateGV(List<String> GV)
        {
               //CHECK = 0;
               //base.sql = "UPDATEGIAOVIEN";
               //SP_DATA();
               //GAN_GV(GV);
               //check();
               SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-6DIRH3U\SQLEXPRESS02;Initial Catalog=QL_HOCSINH_GIAOVIEN;user id=sa;password=123456;Integrated Security=True");
               SqlDataAdapter da = new SqlDataAdapter(cmd);//lưu dữ liệu lấy được vào đây
               //string sSql = "INSERT INTO GiaoVien VALUES (ID_GiaoVien='"+GV[0]+"',TenGV='" + GV[1] + "',SDT=" + GV[2] + ",Email='" + GV[3] + "',GT='" + GV[4] + "',HocHam='" + GV[5] + "',HocVi='" + GV[6]="')";
               string sSql = "UPDATE GiaoVien SET TenGV='"+GV[1]+"' WHERE ID_GiaoVien='"+GV[0]+"'";

               da.InsertCommand = new SqlCommand(sSql, connect);
               connect.Open();
               da.InsertCommand.ExecuteNonQuery();
               connect.Close();
               MessageBox.Show("Cập nhật giáo viên có ID " + GV[0] + " thành công");
          }
        public void DeleteGV(string ID)
        {
               //base.sql = "DELETEGIAOVIEN";
               //SP_DATA();
               //cmd.Parameters.AddWithValue("@ID", ID);
               //cmd.ExecuteNonQuery();
               //cmd.Dispose();
               //con.Close();
               SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-6DIRH3U\SQLEXPRESS02;Initial Catalog=QL_HOCSINH_GIAOVIEN;user id=sa;password=123456;Integrated Security=True");
               SqlDataAdapter da = new SqlDataAdapter(cmd);//lưu dữ liệu lấy được vào đây
               //string sSql = "INSERT INTO GiaoVien VALUES (ID_GiaoVien='"+GV[0]+"',TenGV='" + GV[1] + "',SDT=" + GV[2] + ",Email='" + GV[3] + "',GT='" + GV[4] + "',HocHam='" + GV[5] + "',HocVi='" + GV[6]="')";
               string sSql = "Delete from GiaoVien where ID_GiaoVien='"+ID+"'";

               da.InsertCommand = new SqlCommand(sSql, connect);
               connect.Open();
               da.InsertCommand.ExecuteNonQuery();
               connect.Close();
               MessageBox.Show("Xóa giáo viên có ID " + ID + " thành công");
          }


          public DataTable TK_THONGTIN_MA(string LISTHS)
          {
               base.sql = "TK_THONGTIN_MA";

               SqlDataAdapter sql1 = new SqlDataAdapter(sql, con);
               sql1.SelectCommand.CommandType = CommandType.StoredProcedure;
               sql1.SelectCommand.Parameters.AddWithValue("@ID", LISTHS);
               sql1.SelectCommand.Parameters.Add("@CHECK", SqlDbType.Int).Direction = ParameterDirection.Output;
               sql1.SelectCommand.ExecuteNonQuery();
               CHECK = Convert.ToInt16(sql1.SelectCommand.Parameters["@CHECK"].Value);
               DataTable dt = new DataTable();
               sql1.Fill(dt);
               sql1.Dispose();
               return dt;


          }
          public DataTable TK_THONGTIN_TEN(string LISTGV)
          {
               base.sql = "TK_THONGTIN_TEN";

               SqlDataAdapter sql1 = new SqlDataAdapter(sql, con);
               sql1.SelectCommand.CommandType = CommandType.StoredProcedure;
               sql1.SelectCommand.Parameters.AddWithValue("@NAME", LISTGV);
               sql1.SelectCommand.Parameters.Add("@CHECK", SqlDbType.Int).Direction = ParameterDirection.Output;
               sql1.SelectCommand.ExecuteNonQuery();
               CHECK = Convert.ToInt16(sql1.SelectCommand.Parameters["@CHECK"].Value);
               DataTable dt = new DataTable();
               sql1.Fill(dt);
               sql1.Dispose();
               return dt;

          }
     }
}
