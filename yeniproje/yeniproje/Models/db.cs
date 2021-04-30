
using System;
using System.Data;
using System.Data.SqlClient;

namespace yeniproje.Models
{
    public class db
    {   
        SqlConnection con = new SqlConnection("workstation id=kasatakip.mssql.somee.com;packet size=4096;user id=Cengizhnx_SQLLogin_1;pwd=hvz38dlvi7;data source=kasatakip.mssql.somee.com;persist security info=False;initial catalog=kasatakip");
        //SqlConnection con = new SqlConnection("Data Source=LAPTOP-KBMKH7SD\\SQLEXPRESS;Initial Catalog=kasa;Integrated Security=True");

        public DataSet Empget(EmpClass emp, out string msg)
        {
            DataSet ds = new DataSet();
            msg = "";
            try
            {
                SqlCommand com = new SqlCommand("KT_Sistem2", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", emp.id);
                com.Parameters.AddWithValue("@Kadi", emp.Kadi);
                com.Parameters.AddWithValue("@Tel", emp.Tel);
                com.Parameters.AddWithValue("@Adsoyad", emp.Adsoyad);
                com.Parameters.AddWithValue("@Adres", emp.Adres);
                com.Parameters.AddWithValue("@Acik", emp.Acik);
                com.Parameters.AddWithValue("@ekle", emp.ekle);
                com.Parameters.AddWithValue("@cikar", emp.cikar);
                com.Parameters.AddWithValue("@bakiye", emp.Bakiye);
                com.Parameters.AddWithValue("@flag", emp.flag);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);
                msg = "Islem Basariyla Gerceklestirildi";
                return ds;
            }
            catch(Exception ex)
            {
                msg = ex.Message;
                return ds;
                
            }
            
        }

        public string Empdml(EmpClass emp, out string msg)
        {
            msg = "";
            try
            {
                SqlCommand com = new SqlCommand("KT_Sistem2", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", emp.id);
                com.Parameters.AddWithValue("@Kadi", emp.Kadi);
                com.Parameters.AddWithValue("@Tel", emp.Tel);
                com.Parameters.AddWithValue("@Adsoyad", emp.Adsoyad);
                com.Parameters.AddWithValue("@Adres", emp.Adres);
                com.Parameters.AddWithValue("@Acik", emp.Acik);
                com.Parameters.AddWithValue("@ekle", emp.ekle);
                com.Parameters.AddWithValue("@cikar", emp.cikar);
                com.Parameters.AddWithValue("@bakiye", emp.Bakiye);
                com.Parameters.AddWithValue("@flag", emp.flag);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                msg = "Islem Basariyla Gerceklestirildi";
                return msg;

            }
            catch (Exception ex)
            {
                if(con.State==ConnectionState.Open)
                {
                    con.Close();
                }
                msg = ex.Message;
                return msg;

            }
           
        }
    }
}
