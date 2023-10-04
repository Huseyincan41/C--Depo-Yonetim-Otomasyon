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
    public partial class KullanıcıKayıt : Form
    {
        public KullanıcıKayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3MTJCU5\\SQLEXPRESS;Initial Catalog=\"Depo Yönetim\";Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Kullanıcılar (AD,SOYAD,TC,KULLANICI_ADI,SIFRE)values(@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut.Parameters.AddWithValue("@p1",txtad.Text);
            komut.Parameters.AddWithValue("@p2",txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3",maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p4",txtkulanıcıadı.Text);
            komut.Parameters.AddWithValue("@p5",txtsifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız Oluşturulmuştur");
            txtad.Text = "";
            txtsoyad.Text = "";
            maskedTextBox1.Text = "";
            txtkulanıcıadı.Text = "";
            txtsifre.Text = "";
        }
    }
}
