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
    public partial class Personel_ekleme : Form
    {
        public Personel_ekleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3MTJCU5\\SQLEXPRESS;Initial Catalog=\"Depo Yönetim\";Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
