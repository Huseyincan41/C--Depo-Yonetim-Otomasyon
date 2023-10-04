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


namespace WindowsFormsApp1
{
    public partial class Yoneticigiris : Form
    {
        public Yoneticigiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-3MTJCU5\\SQLEXPRESS;Initial Catalog=\"Depo Yönetim\";Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Depo_görevlileri where KULLANICI_ADI=@p1 AND SIFRE=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1",txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                YöneticiPanel yöneticiPanel = new YöneticiPanel();
                yöneticiPanel.Show();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre hatalı");
            }
            baglanti.Close();
        }
    }
}
