using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MapCharts.Utilities;

namespace MapCharts.DAL
{
    public class mapDAL
    {
        public static SqlConnection conn = new SqlConnection(DBCConnections.GetConnectionString());

        public DataTable GetOutletData()
        {
            try
            {
                if (conn.State == 0)
                {
                    conn.Open();
                }

                string _sql = "SELECT ID, Outlet_Name, Lattitude, Longitude FROM OutletDet";
                SqlCommand cmd = new SqlCommand(_sql, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}