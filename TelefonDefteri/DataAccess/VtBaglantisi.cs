using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonDefteri.DataAccess
{
    public class VtBaglantisi
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TelefonDefteriVT;Integrated Security=True";

        public DataTable VeriGetir(string sqlSatiri)
        {
            DataTable veriTablosu = new DataTable();

            try
            {
                SqlConnection sqlBaglantim = new SqlConnection(connectionString);
                sqlBaglantim.Open();

                SqlDataAdapter sqlVeriAdaptor = new SqlDataAdapter(sqlSatiri, sqlBaglantim);
                int sonuc = sqlVeriAdaptor.Fill(veriTablosu);

                sqlBaglantim.Close();
            }
            catch (Exception)
            {

            }

            return veriTablosu;
        }

        public int VeriGotur(string sqlSatiri)
        {
            int etkilenenSatirAdedi = 0;

            try
            {
                SqlConnection sqlBaglantim2 = new SqlConnection(connectionString);
                sqlBaglantim2.Open();

                SqlCommand sqlKomutu = new SqlCommand(sqlSatiri, sqlBaglantim2);
                etkilenenSatirAdedi = sqlKomutu.ExecuteNonQuery();

                sqlBaglantim2.Close();
            }
            catch (Exception)
            {

            }

            return etkilenenSatirAdedi;
        }


    }
}
