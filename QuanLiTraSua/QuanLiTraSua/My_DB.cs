using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTraSua
{
   

    
        class MY_DB
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OVFOMBP;Initial Catalog=QLTS;Integrated Security=True");
            public SqlConnection getConnection
            {
                get
                {
                    return con;
                }
            }

            public void openConection()
            {
                if ((con.State == ConnectionState.Closed))
                {
                    con.Open();
                }
            }
            public void closeConnection()
            {
                if ((con.State == ConnectionState.Open))
                {
                    con.Close();
                }
            }
            public DataTable bangdulieu = new DataTable();
            public DataTable laybang(string caulenh)
            {
                try
                {
                    openConection();
                    SqlDataAdapter Adapter = new SqlDataAdapter(caulenh, con);
                    DataSet ds = new DataSet();

                    Adapter.Fill(bangdulieu);
                }
                catch (System.Exception)
                {
                    bangdulieu = null;
                }
                finally
                {
                    closeConnection();
                }

                return bangdulieu;
            }
            public void InsertHoaDon(HoaDon_Mod hd)
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        openConection();
                    }

                    string insertQuery = "INSERT INTO HoaDon_Mod (IdHoaDon, NgayTao, SLsanpham ,TongTien, MaNV) VALUES (@IdHoaDon, @NgayTao,@SLsanpham, @TongTien, @MaNV)";

                    using (SqlCommand command = new SqlCommand(insertQuery, getConnection))
                    {
                        command.Parameters.AddWithValue("@IdHoaDon", hd.IdHoaDon);
                        command.Parameters.AddWithValue("@NgayTao", hd.NgayTao.Date);
                        command.Parameters.AddWithValue("@SLsanpham", hd.SoLuongSP);
                        command.Parameters.AddWithValue("@TongTien", hd.TongTien);
                        command.Parameters.AddWithValue("@MaNV", hd.MaNV);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Thêm thành công.");
                        }
                        else
                        {
                            Console.WriteLine("Không thể thêm.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        closeConnection();
                    }
                }
            }
            public void InsertSanPham(SanPham_Mod sp)
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        openConection();
                    }

                    string insertQuery = "INSERT INTO SanPham_mod (IDsanpham, Tensp, Giatien, IDhoadon, Soluong) VALUES (@IDsanpham, @Tensp, @Giatien, @IDhoadon, @Soluong)";

                    using (SqlCommand command = new SqlCommand(insertQuery, getConnection))
                    {
                        command.Parameters.AddWithValue("@IDsanpham", sp.IdSanPham);
                        command.Parameters.AddWithValue("@Tensp", sp.TenSanPham);
                        command.Parameters.AddWithValue("@Giatien", sp.GiaSanPham);
                        command.Parameters.AddWithValue("@IDhoadon", sp.IdHoaDon);
                        command.Parameters.AddWithValue("@Soluong", sp.SoLuong);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Thêm thành công.");
                        }
                        else
                        {
                            Console.WriteLine("Không thể thêm.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        closeConnection();
                    }
                }
            }
        }
    

}
