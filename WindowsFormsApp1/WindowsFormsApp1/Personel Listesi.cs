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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Personel_Listesi : Form
    {
        public Personel_Listesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3MTJCU5\\SQLEXPRESS;Initial Catalog=\"Depo Yönetim\";Integrated Security=True");
        void personel()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD_SOYAD,TC from Tbl_Personel", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Personel_Listesi_Load(object sender, EventArgs e)
        {
            personel();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("update Tbl_Personel set AD_SOYAD=@p1,TC=@p2 where ID=@p3",baglanti);
            komut1.Parameters.AddWithValue("@p1",txtad.Text);
            komut1.Parameters.AddWithValue("@p2",maskedTextBox1.Text);
            komut1.Parameters.AddWithValue("@p3",txtid.Text);
            komut1.ExecuteNonQuery();
            MessageBox.Show("Personel Bilgisi Güncellendi");
            txtid.Text = "";
            txtad.Text = "";
            maskedTextBox1.Text = "";
            personel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (AD_SOYAD,TC)values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Personel eklenmiştir");
            personel();
            txtid.Text = "";
            txtad.Text = "";
            maskedTextBox1.Text = "";
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Delete from Tbl_Personel where ID=" + txtid.Text, baglanti);
            komut1.ExecuteNonQuery();
            MessageBox.Show("ürün silinmiştir");
            personel();
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtad.Text = "";
            maskedTextBox1.Text = "";
        }
    }
}
