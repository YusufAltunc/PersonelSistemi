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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        SqlConnection baglantı = new SqlConnection("Data Source=YUSUF\\SQLEXPRESS;Initial Catalog=bospersonelveritabani;Integrated Security=True");

        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtmeslek.Text = "";
            mskmaas.Text = "";
            cmbsehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtad.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sqldeki girdigin verileri sana yazdırır.
            this.tbl_PersonelTableAdapter.Fill(this.bospersonelveritabaniDataSet.Tbl_Personel);
            //label8.Visible = false;

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.bospersonelveritabaniDataSet.Tbl_Personel);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (Perad,Persoyad,Persehir,Permaas,Permeslek,Perdurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglantı);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbsehir.Text);
            komut.Parameters.AddWithValue("@p4", mskmaas.Text);
            komut.Parameters.AddWithValue("@p5", txtmeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);

            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Personel eklendi.");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                label8.Text = "False";
            }
        }

        private void btntemizlik_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void txtsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text=dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text=="True")
            {
                radioButton1.Checked = true;
            }
            if(label8.Text=="False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1", baglantı);
            komutsil.Parameters.AddWithValue("@k1",txtid.Text);
            komutsil.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt silindi.");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set Perad=@a1,Persoyad=@a2,Persehir=@a3,Permaas=@a4,Perdurum=@a5,Permeslek=@a6 where Perid=@a7", baglantı);
            komutguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", cmbsehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", mskmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtid.Text);
            komutguncelle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Personel bilgi guncellendi.");
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            frmistatistik fr = new frmistatistik();
            fr.Show();
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            Frmgrafikler frmg = new Frmgrafikler();
            frmg.Show();
        }
    }
}
