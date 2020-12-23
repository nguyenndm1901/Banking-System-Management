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
    public class HoSo_DAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        public List<HoSo_DTO> select()
        {
            string query = string.Empty;
            query += "SELECT [id], [tenKH], [soTien], [ngayDangKy], [kyHan], [nhanVienDuyet], [tinhTrang]";
            query += "FROM [HoSoVayVon]";

            List<HoSo_DTO> lsHoSo = new List<HoSo_DTO>();

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
                                HoSo_DTO dt = new HoSo_DTO();
                                dt.id = reader["id"].ToString();
                                dt.tenKH = reader["tenKH"].ToString();
                                //dt.soTien = Convert.ToInt32(reader["soTien"].ToString());
                                dt.soTien = string.Format("{0:n0}", int.Parse(reader["soTien"].ToString()));
                                DateTime output;
                                DateTime.TryParse(reader["ngayDangKy"].ToString(),CultureInfo.InvariantCulture, DateTimeStyles.None, out output);
                                dt.ngayDangKy = output.ToShortDateString(); ;
                                dt.kyHan = Convert.ToInt16(reader["kyHan"].ToString());
                                dt.nhanVienDuyet = reader["nhanVienDuyet"].ToString();
                                dt.tinhTrang = reader["tinhTrang"].ToString();
                                lsHoSo.Add(dt);
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
            return lsHoSo;
        }
    }
}
