using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ayçiçeği_Pansiyon_Uygulaması
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"server=.\SQLEXPRESS;database=AycicegiPansiyon;Integrated Security=True");

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where Kullanici=@Kullanici AND Sifre=@Sifre";
                SqlParameter pr1 = new SqlParameter("Kullanici", txtKullaniciadi.Text.Trim());
                SqlParameter pr2 = new SqlParameter("Sifre", txtsifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(pr1);
                komut.Parameters.Add(pr2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FrmAnaModul fr = new FrmAnaModul();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
        }
    }
}
