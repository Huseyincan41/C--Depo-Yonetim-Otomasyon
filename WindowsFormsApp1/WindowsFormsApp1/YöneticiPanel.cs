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
    public partial class YöneticiPanel : Form
    {
        public YöneticiPanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3MTJCU5\\SQLEXPRESS;Initial Catalog=\"Depo Yönetim\";Integrated Security=True");
        void urunler()
        {
            SqlDataAdapter da=new SqlDataAdapter("Select *from Tbl_Urunler",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        
        void eskiurun()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select ID,URUNMARKA,URUNMODEL,URUNKATEGORI,URUNKOD from Tbl_Guncellenenurun", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
        }
        private void YöneticiPanel_Load(object sender, EventArgs e)
        {
            
            urunler();
           eskiurun();
            baglanti.Open();
            SqlCommand komut1= new SqlCommand("Select AD_SOYAD From Tbl_Personel",baglanti);
            SqlDataReader dr=komut1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["AD_SOYAD"]);
            }
            baglanti.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Urunler (URUNMARKA,URUNMODEL,URUNKATEGORI,URUNKOD,PERSONEL) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1",txt_marka.Text);
            komut.Parameters.AddWithValue("@p2", txt_model.Text);
            komut.Parameters.AddWithValue("@p3", txt_kategori.Text);
            komut.Parameters.AddWithValue("@p4", txt_kod.Text);
            komut.Parameters.AddWithValue("@p5", comboBox1.Text);
            komut.ExecuteNonQuery();
            
            urunler();
            MessageBox.Show("Ürün Eklendi");
            baglanti.Close();
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Update Tbl_Urunler set  URUNMARKA=@p1,URUNMODEL=@p2,URUNKATEGORI=@p3,URUNKOD=@p4,PERSONEL=@p5 where  URUNID=@p6 ", baglanti);
            
            komut2.Parameters.AddWithValue("@p1",txt_marka.Text);
            komut2.Parameters.AddWithValue("@p2", txt_model.Text);
            komut2.Parameters.AddWithValue("@p3", txt_kategori.Text);
            komut2.Parameters.AddWithValue("@p4", txt_kod.Text);
            komut2.Parameters.AddWithValue("@p5", comboBox1.Text);
            komut2.Parameters.AddWithValue("@p6", txt_id.Text);
            komut2.ExecuteNonQuery();
            urunler();
            MessageBox.Show("Ürün Güncellendi");
            baglanti.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_marka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_model.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_kategori.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_kod.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            
            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Delete from Tbl_Urunler where URUNID="+txt_id.Text,baglanti);
            komut3.ExecuteNonQuery();
            MessageBox.Show("ürün silinmiştir");
            urunler();
            baglanti.Close();
        }
        void ürüncıkar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Tbl_Guncellenenurun where ID="+lblid.Text,baglanti);
            komut.ExecuteNonQuery();
            eskiurun();
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_marka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_model.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_kategori.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_kod.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            int secilen2= dataGridView3.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView3.Rows[secilen2].Cells[0].Value.ToString();
            lblmarka.Text = dataGridView3.Rows[secilen2].Cells[1].Value.ToString();
            lblmodel.Text = dataGridView3.Rows[secilen2].Cells[2].Value.ToString();
            lblkategori.Text = dataGridView3.Rows[secilen2].Cells[3].Value.ToString();
            lblkod.Text = dataGridView3.Rows[secilen2].Cells[4].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel_ekleme pe=new Personel_ekleme();
            pe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personel_Listesi pe=new Personel_Listesi();
            pe.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Urunler (URUNMARKA,URUNMODEL,URUNKATEGORI,URUNKOD,PERSONEL) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", lblmarka.Text);
            komut.Parameters.AddWithValue("@p2", lblmodel.Text);
            komut.Parameters.AddWithValue("@p3", lblkategori.Text);
            komut.Parameters.AddWithValue("@p4", lblkod.Text);
            komut.Parameters.AddWithValue("@p5", comboBox1.Text);
            komut.ExecuteNonQuery();
            urunler();
            MessageBox.Show("Ürün Eklendi");
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Delete from Tbl_Guncellenenurun where ID=" + lblid.Text, baglanti);
            komut3.ExecuteNonQuery();
            
            baglanti.Close();
            eskiurun();
            urunler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BildirimPanel bp= new BildirimPanel();
            bp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_marka.Text = "";
            txt_model.Text = "";
            txt_kategori.Text = "";
            txt_kod.Text = "";
            comboBox1.Text = "";
        }
    }
}
