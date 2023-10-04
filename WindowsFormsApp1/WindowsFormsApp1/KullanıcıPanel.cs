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
    public partial class KullanıcıPanel : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3MTJCU5\\SQLEXPRESS;Initial Catalog=\"Depo Yönetim\";Integrated Security=True");
        public KullanıcıPanel()
        {
            InitializeComponent();
        }
        public string kula;
        void urunler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select  URUNID,URUNMARKA,URUNMODEL,URUNKATEGORI,URUNKOD from Tbl_Urunler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void urun2()
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select ID,URUNMARKA,URUNMODEL,URUNKATEGORI,URUNKOD from Tbl_ZIMMETLIURUNLER where ZIMMETLIKULLANICIADI='" + label1.Text + "'", baglanti);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                lblurunid.Text = dr.GetValue(0).ToString();
                
                lbl_marka.Text = dr.GetValue(1).ToString();
                lbl_model.Text = dr.GetValue(2).ToString();
                lbl_kategori.Text = dr.GetValue(3).ToString();
                lbl_kod.Text = dr.GetValue(4).ToString();
            }
            baglanti.Close();
        }
        void sart()
        {
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("SELECT * from Tbl_ZIMMETLIURUNLER where ZIMMETLIKULLANICIADI=@p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", label1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
        }

        private void KullanıcıPanel_Load(object sender, EventArgs e)
        {
            
            urunler();
            label1.Text = kula;
            urun2();
            sart();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            txtmarka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtmodel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtkategori.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtkod.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_ZIMMETLIURUNLER (ZIMMETLIKULLANICIADI,URUNMARKA,URUNMODEL,URUNKATEGORI,URUNKOD) values (@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut.Parameters.AddWithValue("@p1",label1.Text);
            komut.Parameters.AddWithValue("@p2",txtmarka.Text);
            komut.Parameters.AddWithValue("@p3",txtmodel.Text);
            komut.Parameters.AddWithValue("@p4",txtkategori.Text);
            komut.Parameters.AddWithValue("@p5",txtkod.Text);
            komut.ExecuteNonQuery();
            
            MessageBox.Show("ürün zimmete geçirildi");
            
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Delete from Tbl_Urunler where URUNID="+txtid.Text,baglanti);
            
            komut6.ExecuteNonQuery();
            baglanti.Close();
            urun2();
           
            
            urunler();
            sart();

        }
        void bildirim()
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into Tbl_Bildirim (GUNCELLENENADSOYAD,URUNMARKA,URUNMODEL,URUNKATEGORI,URUNKOD) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut3.Parameters.AddWithValue("@p1", label1.Text);
            komut3.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut3.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut3.Parameters.AddWithValue("@p4", txtkategori.Text);
            komut3.Parameters.AddWithValue("@p5", txtkod.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("insert into Tbl_Guncellenenurun (URUNMARKA,URUNMODEL,URUNKATEGORI,URUNKOD) values (@p1,@p2,@p3,@p4)",baglanti);
            komut4.Parameters.AddWithValue("@p1",lbl_marka.Text);
            komut4.Parameters.AddWithValue("@p2",lbl_model.Text);
            komut4.Parameters.AddWithValue("@p3",lbl_kategori.Text);
            komut4.Parameters.AddWithValue("@p4", lbl_kod.Text);
            komut4.ExecuteNonQuery();
            baglanti.Close();
            bildirim();
            //baglanti.Open();
            //SqlCommand komut5 = new SqlCommand("Delete from Tbl_Urunler where URUNID="+txtid.Text,baglanti);
            //komut5.ExecuteNonQuery();

            //baglanti.Close();
            //baglanti.Open();
            //SqlCommand komut2 = new SqlCommand("Update Tbl_ZIMMETLIURUNLER set URUNMARKA=@p1,URUNMODEL=@p2,URUNKATEGORI=@p3,URUNKOD=@p4 where ZIMMETLIKULLANICIADI=@p5 ", baglanti);
            //komut2.Parameters.AddWithValue("@p1",txtmarka.Text);
            //komut2.Parameters.AddWithValue("@p2", txtmodel.Text);
            //komut2.Parameters.AddWithValue("@p3", txtkategori.Text);
            //komut2.Parameters.AddWithValue("@p4", txtkod.Text);

            //komut2.Parameters.AddWithValue("@p5", label1.Text);
            //komut2.ExecuteNonQuery();
            //MessageBox.Show("zimmetli eşya güncellendi");

            //baglanti.Close();
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Delete from Tbl_ZIMMETLIURUNLER  where ID="+lblurunid.Text,baglanti);
            komut6.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün zimmetden çıkarıldı");
            
            urun2();
            urunler();
            sart();
            

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen2 = dataGridView2.SelectedCells[0].RowIndex;
            lblurunid.Text = dataGridView2.Rows[secilen2].Cells[0].Value.ToString();
            lblkulad.Text = dataGridView2.Rows[secilen2].Cells[1].Value.ToString();
            lbl_marka.Text = dataGridView2.Rows[secilen2].Cells[2].Value.ToString();
           lbl_model.Text = dataGridView2.Rows[secilen2].Cells[3].Value.ToString();
            lbl_kategori.Text = dataGridView2.Rows[secilen2].Cells[4].Value.ToString();
            lbl_kod.Text = dataGridView2.Rows[secilen2].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanıcıbilgi kul=new kullanıcıbilgi();
            kul.id=label1.Text;
            kul.Show();
        }
    }
}
