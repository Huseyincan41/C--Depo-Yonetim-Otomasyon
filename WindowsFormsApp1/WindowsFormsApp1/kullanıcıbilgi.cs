using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class kullanıcıbilgi : Form
    {
        public kullanıcıbilgi()
        {
            InitializeComponent();
        }
        public string id;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3MTJCU5\\SQLEXPRESS;Initial Catalog=\"Depo Yönetim\";Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2= new SqlCommand("update Tbl_Kullanıcılar set AD=@p1,SOYAD=@p2,TC=@p3,KULLANICI_ADI=@p4,SIFRE=@p5 where Id=@p6",baglanti);
            komut2.Parameters.AddWithValue("@p1",txtad.Text);
            komut2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut2.Parameters.AddWithValue("@p4", txtkullanıcıadı.Text);
            komut2.Parameters.AddWithValue("@p5", txtsifre.Text);
            komut2.Parameters.AddWithValue("@p6", txtid.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Bilgiler güncellendi");
            baglanti.Close();
            bilgi();
        }
        void bilgi()
        {
            SqlCommand komut = new SqlCommand("Select  ıd,AD,SOYAD,TC,KULLANICI_ADI,SIFRE from Tbl_Kullanıcılar where KULLANICI_ADI=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",label7.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void kullanıcıbilgi_Load(object sender, EventArgs e)
        {
            
            label7.Text = id;
            
            bilgi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtkullanıcıadı.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
