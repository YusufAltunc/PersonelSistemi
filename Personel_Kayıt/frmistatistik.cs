using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayıt
{
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=YUSUF\\SQLEXPRESS;Initial Catalog=bospersonelveritabani;Integrated Security=True");

        private void frmistatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", baglantı);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lbltoplampersonel.Text=dr1[0].ToString();
            }   
            baglantı.Close();

            //Evli Personel Sayısı
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel where Perdurum=1",baglantı);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                lblevlipersonel.Text=dr2[0].ToString();
            }
            baglantı.Close();

            //Bekar Personel Sayısı
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel where Perdurum=0", baglantı);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                lblbekarpersonel.Text=dr3[0].ToString();
            }
            baglantı.Close();

            //Şehir Sayısı
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(Persehir)) From Tbl_Personel", baglantı);
            //distinct kelimesi aynı nesneleri tekrarlamaz bir kere alır ve sayar.
            SqlDataReader dr4 = komut4.ExecuteReader();
            while(dr4.Read())
            {
                lblsehir.Text=dr4[0].ToString();
            }
            baglantı.Close ();

            //Toplam Maaş
            baglantı.Open ();
            SqlCommand komut5 = new SqlCommand("Select Sum(Permaas) From Tbl_Personel", baglantı);
            //count sayar , sum toplar.
            SqlDataReader d5 = komut5.ExecuteReader();
            while(d5.Read())
            {
                lbltoplammaas.Text=d5[0].ToString();
            }
            baglantı.Close();

            //Ortalama Maaş
            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(Permaas) From Tbl_Personel", baglantı);
            //count sayar , sum toplar , avg ortalama alır.
            SqlDataReader d6 = komut6.ExecuteReader();
            while (d6.Read())
            {
                lblortalamamaas.Text = d6[0].ToString();
            }
            baglantı.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
