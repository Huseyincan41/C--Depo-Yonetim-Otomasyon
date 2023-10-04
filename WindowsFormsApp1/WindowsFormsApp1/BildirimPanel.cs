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
    public partial class BildirimPanel : Form
    {
        public BildirimPanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3MTJCU5\\SQLEXPRESS;Initial Catalog=\"Depo Yönetim\";Integrated Security=True");
        void bildirim()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select ID,GUNCELLENENADSOYAD,URUNMARKA,URUNMODEL,URUNKATEGORI,URUNKOD from Tbl_Bildirim", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        private void BildirimPanel_Load(object sender, EventArgs e)
        {
            bildirim();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            lblad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            lblmarka.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            lblmodel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            lblkategori.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lblkod.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Tbl_Bildirim where ID="+lblıd.Text,baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bildirim Temizlendi");
            baglanti.Close();
            bildirim();
        }
    }
}
