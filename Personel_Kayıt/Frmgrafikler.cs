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
    public partial class Frmgrafikler : Form
    {
        public Frmgrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=YUSUF\\SQLEXPRESS;Initial Catalog=bospersonelveritabani;Integrated Security=True");

        


        private void Frmgrafikler_Load(object sender, EventArgs e)
        {
            //Grafik 1
            baglantı.Open();
            SqlCommand komutg1 = new SqlCommand("Select Persehir,Count(*) From Tbl_Personel Group By Persehir", baglantı);
            SqlDataReader dr1=komutg1.ExecuteReader();
            while(dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);

            }
            baglantı.Close();

            //Grafik 2
            baglantı.Open();
            SqlCommand komutg2 = new SqlCommand("Select Permeslek,Avg(Permaas) From Tbl_Personel Group By Permeslek", baglantı);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0],dr2[1]);
            }
            baglantı.Close();


        }
    }
}
