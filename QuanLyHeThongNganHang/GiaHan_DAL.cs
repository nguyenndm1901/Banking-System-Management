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
    public class GiaHan_DAL
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        public List<GiaHan_DTO> select()
        {
            string query = string.Empty;
            query += "SELECT [id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]";
            query += "FROM [GiaHanVayVon]";

            List<GiaHan_DTO> lsGiaHan = new List<GiaHan_DTO>();

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
                                GiaHan_DTO dt = new GiaHan_DTO();
                                dt.id = reader["id"].ToString();
                                dt.tenKH = reader["tenKH"].ToString();
                                dt.maHoSo = reader["maHoSo"].ToString();
                                dt.lyDo = reader["lyDo"].ToString();
                                dt.kyHanCu = Convert.ToInt16(reader["kyHanCu"].ToString());
                                dt.kyHanMoi = Convert.ToInt16(reader["kyHanMoi"].ToString());
                                DateTime output;
                                DateTime.TryParse(reader["ngayDangKy"].ToString(), CultureInfo.InvariantCulture, DateTimeStyles.None, out output);
                                dt.ngayDangKy = output.ToShortDateString();
                                dt.tinhTrang = reader["tinhTrang"].ToString();
                                dt.nhanVienDuyet = reader["nhanVienDuyet"].ToString();
                                lsGiaHan.Add(dt);
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
            return lsGiaHan;
        }
    }
}
