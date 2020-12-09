using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using System.Data.SqlClient;
using System.Data;
namespace FACADELAYERR
{
    public class FACADEKULUP
    {
        public static int EKLE(ENTITYKULUP deger)
        {
            SqlCommand komut = new SqlCommand("KULUPEKLE", SQLBAGLANTISI.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            
            if(komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KULUPADI", deger.KULUPAD);
            return komut.ExecuteNonQuery();
        }

        public static bool SIL(int deger)
        {
            SqlCommand komut = new SqlCommand("KULUPSIL", SQLBAGLANTISI.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if(komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KULUPID", deger);
            return komut.ExecuteNonQuery() > 0;
        }

        public static bool GUNCELLE(ENTITYKULUP deger)
        {
            SqlCommand komut = new SqlCommand("KULUPGUNCELLE", SQLBAGLANTISI.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if(komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KULUPADI", deger.KULUPAD);
            komut.Parameters.AddWithValue("KULUPID", deger.KULUPID);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<ENTITYKULUP>KULUPLISTESİ()
        {
            List<ENTITYKULUP> degerler = new List<ENTITYKULUP>();
            SqlCommand komut = new SqlCommand("KULUPLISTESI", SQLBAGLANTISI.Baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                ENTITYKULUP ent = new ENTITYKULUP();
                ent.KULUPID = Convert.ToInt32(dr["KULUPID"]);
                ent.KULUPAD = dr["KULUPADI"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
