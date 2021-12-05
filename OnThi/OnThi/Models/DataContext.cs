using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi.Models
{
    public class DataContext
    {

        public string ConnectionString { get; set; }
        public DataContext(string connectionstring)
        {
            this.ConnectionString = connectionstring;
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        //sql table canho
        public int SqlInsertCanHo(CanHoModel canho)
        {
            using(SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into canho values(@macanho, @tencanho)";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("macanho", canho.maCanHo);
                cmd.Parameters.AddWithValue("tencanho", canho.tenChuHo);
                return (cmd.ExecuteNonQuery());
            }           
        }
        //sql nhanvien
        public List<NhanVienModel> SqlListNhanVien()
        {
            List<NhanVienModel> list = new List<NhanVienModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"SELECT * FROM NHANVIEN";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVienModel()
                        {
                            maNhanVien = reader["manhanvien"].ToString(),
                            tenNhanVien = reader["tennhanvien"].ToString(),
                            soDienThoai = reader["sodienthoai"].ToString(),
                            gioiTinh = Convert.ToInt32(reader["gioitinh"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<object> sqlListByTimeNhanVien(int soLan)
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select nv.manhanvien, nv.tennhanvien, nv.sodienthoai, count(*) AS SoLan
                                from nhanvien nv join nv_bt on nv.manhanvien = nv_bt.manhanvien 
                                group by nv.manhanvien, nv.tennhanvien, nv.sodienthoai
                                having count(*) >= @SoLanInput";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("SoLanInput", soLan);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            TenNV = reader["tennhanvien"].ToString(),
                            SoDT = reader["sodienthoai"].ToString(),
                            SoLan = Convert.ToInt32(reader["SoLan"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<object> SqlLietKeThietBi(string MaNhanVien)
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = @"select mathietbi, macanho, lanthu, ngaybaotri, n.manhanvien from NV_BT n
                                JOIN NHANVIEN ON n.manhanvien = NHANVIEN.manhanvien
                                where NHANVIEN.manhanvien = @MaNhanVienInput;";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaNhanVienInput", MaNhanVien);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add (new
                        {
                            maThietBi = reader["mathietbi"].ToString(),
                            maCanHo= reader["macanho"].ToString(),
                            lanThu = Convert.ToInt32(reader["lanthu"]),
                            ngayBaoTri = Convert.ToDateTime(reader["ngaybaotri"]),
                            maNhanVien = MaNhanVien

                        });
                                              
                    }
                    reader.Close(); 
                }
                conn.Close();              
            }
            return list;
        }
        public int SqlXoaThietBi(string MaNV, string MaTB, string MaCH, int LanThu)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                
                var str = @"delete NV_BT where MaNhanVien=@maNhanVien and MaThietBi=@maThietBi and MaCanHo=@maCanHo and LanThu=@lanThu";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("maNhanVien", MaNV);
                cmd.Parameters.AddWithValue("maThietBi", MaTB);
                cmd.Parameters.AddWithValue("maCanHo", MaCH);
                cmd.Parameters.AddWithValue("lanThu", LanThu);
                return (cmd.ExecuteNonQuery());


            }
        }
        public NV_BTModel SqlViewThietBi(string MaNV, string MaTB, string MaCH, int LanThu)
        {
            NV_BTModel bt = new NV_BTModel();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from NV_BT where MaNhanVien=@maNhanVien and MaThietBi=@maThietBi and MaCanHo=@maCanHo and LanThu=@lanThu;";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("maNhanVien", MaNV);
                cmd.Parameters.AddWithValue("maThietBi", MaTB);
                cmd.Parameters.AddWithValue("maCanHo", MaCH);
                cmd.Parameters.AddWithValue("lanThu", LanThu);
               // cmd.Parameters.AddWithValue("ngayBaoTri", bt.ngayBaoTri);


                //cmd.Parameters["@manhanvien"].Value = Manv;

                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    bt.maThietBi = reader["MaThietBi"].ToString();
                    bt.maCanHo = reader["MaCanHo"].ToString();
                    bt.lanThu = Convert.ToInt32(reader["LanThu"]);
                    bt.ngayBaoTri = Convert.ToDateTime(reader["NgayBaoTri"]);
                    bt.maNhanVien = reader["MaNhanVien"].ToString();
                }
            }
            return (bt);
        }
        public int SqlUpdateNVBT(string maThietBiCu, string maCanHoCu, int lanThuCu, NV_BTModel nv)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"update NV_BT set MaThietBi =@maThietBi, MaCanHo =@maCanHo, LanThu =@lanThu, NgayBaoTri=@ngayBT
                            where MaNhanVien=@maNhanVien and MaThietBi=@maTBCu and MaCanHo=@maCHCu and LanThu=@lanThuCu";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("maNhanVien", nv.maNhanVien);
                cmd.Parameters.AddWithValue("maThietBi", nv.maThietBi);
                cmd.Parameters.AddWithValue("maCanHo", nv.maCanHo);
                cmd.Parameters.AddWithValue("lanThu", nv.lanThu);
                cmd.Parameters.AddWithValue("maTBCu", maThietBiCu);
                cmd.Parameters.AddWithValue("maCHCu", maCanHoCu);
                cmd.Parameters.AddWithValue("lanThuCu", lanThuCu);
                cmd.Parameters.AddWithValue("ngayBT", nv.ngayBaoTri.ToString("yyyy-MM-dd"));
                return (cmd.ExecuteNonQuery());
            }
        }
    }
}
