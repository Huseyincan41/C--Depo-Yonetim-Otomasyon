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
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1
{
    public partial class Kullanıcıgiris : Form
    {
        
        public Kullanıcıgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3MTJCU5\\SQLEXPRESS;Initial Catalog=\"Depo Yönetim\";Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut=new SqlCommand("Select * From Tbl_Kullanıcılar Where KULLANICI_ADI=@p1 AND SIFRE=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1",txt_kullanıcıad.Text);
            komut.Parameters.AddWithValue("@p2",txt_sifre.Text);
            
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                KullanıcıPanel kullanıcıPanel=new KullanıcıPanel();
                kullanıcıPanel.kula = txt_kullanıcıad.Text;
                kullanıcıPanel.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            baglanti.Close();
        }

        private void Kullanıcıgiris_Load(object sender, EventArgs e)
        {
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullanıcıKayıt kk=new KullanıcıKayıt();
            kk.Show();
        }
    }
}
