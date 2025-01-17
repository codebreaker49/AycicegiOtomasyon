﻿using System;
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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"server=.\SQLEXPRESS;database=AycicegiPansiyon;Integrated Security=True");
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            /*baglanti.Open();
            SqlCommand komut = new SqlCommand(" select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();*/

            int personel;
            personel = Convert.ToInt16(txtPersonelSayisi.Text);
            lblPersonelmaas.Text = (personel*1500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(lblKasaToplam.Text) - (Convert.ToInt32(lblPersonelmaas.Text) + Convert.ToInt32(lbluruntutar.Text) + Convert.ToInt32(lbluruntutar2.Text) + Convert.ToInt32(lbluruntutar3.Text) + Convert.ToInt32(lblFaturalar.Text) + Convert.ToInt32(lblFaturalar1.Text) + Convert.ToInt32(lblFaturalar2.Text));
            lblSonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand(" select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                lbluruntutar.Text = oku1["toplam1"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand(" select sum(İcecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lbluruntutar2.Text = oku2["toplam2"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(" select sum(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lbluruntutar3.Text = oku3["toplam3"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand(" select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblFaturalar.Text = oku4["toplam4"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand(" select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblFaturalar1.Text = oku5["toplam5"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand(" select sum(Internet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblFaturalar2.Text = oku6["toplam6"].ToString();
            }
            baglanti.Close();
        }
    }
}
