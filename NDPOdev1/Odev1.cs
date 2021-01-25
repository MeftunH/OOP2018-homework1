/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1
**				ÖĞRENCİ ADI............:Maftun Hashimli
**				ÖĞRENCİ NUMARASI.......:G181210554
**              DERSİN ALINDIĞI GRUP...: C
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public string[] kelimeler;
        public string[] satirlar;

        public Form1()
        {
            InitializeComponent();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();//Kullanıcı dosya seçimi yapar.         
            {

                if (openFile.ShowDialog() == DialogResult.OK)

                {

                    StreamReader sr = new StreamReader(openFile.FileName, Encoding.GetEncoding("iso_8859-9"));
                    richTextBox1.Text = sr.ReadToEnd();//Veriler seçilen dosyadan okunur ve gösterilir.
                    sr.Close();
                    textBox1.Text = openFile.FileName;//dosya yolu gösterilir.
                    string[] satirlar;
                    string hepsi = richTextBox1.Text;
                    satirlar = hepsi.Split('\n');//Dosya satırlara ayrılabilir.
                    foreach (string s in satirlar)//personel bilgileri(satırlar) ayrıştırılabilir.
                    {
                        string[] kelimeler = s.Split(' ');
                        listView1.Items.Add(new ListViewItem(kelimeler));
                    }
                }
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader("C:\\Users\\Molner\\Desktop\\textfile.txt");
            //richTextBox1.Text = sr.ReadToEnd();
            //sr.Close();
            listView1.Columns.Add("TC KİMLİK NO", 155);

            listView1.Columns.Add("ADI", 100);

            listView1.Columns.Add("SOYADI", 100);

            listView1.Columns.Add("YAŞ", 50);

            listView1.Columns.Add("ÇALIŞMA SÜRESİ", 40);

            listView1.Columns.Add("EVLİLİK DURUMU", 25);

            listView1.Columns.Add("EŞİ ÇALIŞIYORMU", 45);

            listView1.Columns.Add("ÇOCUK SAYISI", 45);

            listView1.Columns.Add("TABAN MAAŞ", 65);

            listView1.Columns.Add("MAKAM TAZMİNATI", 55);

            listView1.Columns.Add("İDARİ GÖREV TAZMİNATI", 55);

            listView1.Columns.Add("FAZLA MESAİ SAATİ", 55);

            listView1.Columns.Add("FAZLA MESAİ ÜCRETİ", 55);

            listView1.Columns.Add("VERGİ MATRAHI", 70);

            listView1.Columns.Add("PERSONEL RESMİ YOLU", 80);


        }

        public void tcara_Click(object sender, EventArgs e)
        {
            
            if (txttcara.TextLength != 11)
            {
                MessageBox.Show("Lutfen 11 karakterli TC numarasini giriniz");
            }

            else
            {
                {
                    for (int i = 0; i < listView1.Items.Count; i++)

                    {

                        if (listView1.Items[i].SubItems[0].Text == txttcara.Text)

                        {

                            txttc.Text = listView1.Items[i].SubItems[0].Text;
                            txtisim.Text = listView1.Items[i].SubItems[1].Text;
                            txtsoyisim.Text = listView1.Items[i].SubItems[2].Text;
                            txtyas.Text = listView1.Items[i].SubItems[3].Text;
                            txtcalismasuresi.Text = listView1.Items[i].SubItems[4].Text;
                            txtevlilik.Text = listView1.Items[i].SubItems[5].Text;
                            txtesicalisiyormu.Text = listView1.Items[i].SubItems[6].Text;
                            txtcocuksayisi.Text = listView1.Items[i].SubItems[7].Text;
                            txttbnmaas.Text = listView1.Items[i].SubItems[8].Text;
                            txtmkmtazminati.Text = listView1.Items[i].SubItems[9].Text;
                            txtidarigrvtzmnti.Text = listView1.Items[i].SubItems[10].Text;
                            txtfzlmesai.Text = listView1.Items[i].SubItems[11].Text;
                            txtfzlmesaisaatucreti.Text = listView1.Items[i].SubItems[12].Text;
                            txtvergimatrahi.Text = listView1.Items[i].SubItems[13].Text;
                            txtresim.Text = listView1.Items[i].SubItems[14].Text;
                        }
                    }
                }

            }
            


                }

                public void listView1_SelectedIndexChanged(object sender, EventArgs e)
                {
                    listView1.Scrollable = true;

                    listView1.View = View.Details;

                    listView1.FullRowSelect = true;
                }

                public void btnhesapla_Click(object sender, EventArgs e)
                {
                    {
                        float vergimatrahi, damgavergisi, tabanmaas, makamtazminati, brutmaas, idarigorev, cocuksayisi, fazlamesaiisaati, fazlamesaiiucreti;
                        float emeklikesintisi, gelirvergisi, netmaas;
                        fazlamesaiisaati = Convert.ToInt32(txtfzlmesai.Text);
                        fazlamesaiiucreti = Convert.ToInt32(txtfzlmesaisaatucreti.Text);
                        cocuksayisi = Convert.ToInt32(txtcocuksayisi.Text);
                        idarigorev = Convert.ToInt32(txtidarigrvtzmnti.Text);
                        tabanmaas = Convert.ToInt32(txttbnmaas.Text);
                        makamtazminati = Convert.ToInt32(txtmkmtazminati.Text);
                        brutmaas = tabanmaas + makamtazminati + idarigorev + cocuksayisi * 30 + fazlamesaiiucreti * fazlamesaiisaati;
                        txtbxmaas.Text = Convert.ToString(brutmaas);
                        vergimatrahi = Convert.ToInt32(txtvergimatrahi.Text);
 

                        if (txtesicalisiyormu.Text=="H")
                        {
                            brutmaas = brutmaas + 200;
                        }
                else
                {
                    brutmaas = brutmaas + 0;
                }
                        damgavergisi = brutmaas / 10;
                        if (vergimatrahi < 10000)
                        {
                            gelirvergisi = brutmaas * 15 / 100;
                           

                        }
                        else if (vergimatrahi > 10000 && vergimatrahi < 20000 && vergimatrahi == 10000)
                        {
                            gelirvergisi = brutmaas * 1 / 5;
                            
                        }
                        else if (vergimatrahi > 20000 && vergimatrahi < 30000)
                        {
                            gelirvergisi = brutmaas * 1 / 4;
                         
                        }
                        else
                        {
                            gelirvergisi = brutmaas * 3 / 10;
                            
                        }
               
                        emeklikesintisi = brutmaas * 15 / 100;
                       
                        netmaas = brutmaas - (emeklikesintisi + gelirvergisi + damgavergisi);
                        txtbxmaas.Text = Convert.ToString(netmaas+" TL");
                    }

                }

                private void pictureBox1_Click(object sender, EventArgs e)
                {

                }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttcara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtglrvergisiaktar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtbxmaas_TextChanged(object sender, EventArgs e)
        {

        }
    }
        }
    
