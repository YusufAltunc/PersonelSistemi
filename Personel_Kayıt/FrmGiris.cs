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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=YUSUF\\SQLEXPRESS;Initial Catalog=bospersonelveritabani;Integrated Security=True");

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Yonetici where KullaniciAd=@p1 and Sifre=@p2", baglantı);
            komut.Parameters.AddWithValue("@p1",txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
            }
            baglantı.Close();
        }
    }
}
