using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHeThongNganHang
{
    public class TaiSan_DAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        public List<TaiSan_DTO> select()
        {
            string query = string.Empty;
            query += "SELECT [id] [maHoSo], [benB], [taiSan]";
            query += "FROM [HopDong]";

            List<TaiSan_DTO> lsTaiSan = new List<TaiSan_DTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                TaiSan_DTO dt = new TaiSan_DTO();
                                dt.id = reader["id"].ToString();
                                dt.maHoSo = reader["maHoSo"].ToString();
                                dt.benB = reader["benB"].ToString();
                                dt.taiSan = reader["taiSan"].ToString();
                                lsTaiSan.Add(dt);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsTaiSan;
        }
    }
}
