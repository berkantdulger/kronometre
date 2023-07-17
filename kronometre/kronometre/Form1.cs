using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometre
{
    public partial class Form1 : Form
    {
        int saat = 0;
        int saniye=0;
        int dakika = 0;
        int sayac = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "başlat";
            button2.Text = "sıfırla";
            label1.Text = saat.ToString() + ":" + dakika.ToString() + ":" + saniye.ToString();
            button3.Text = "tur";
            button3.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int durum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(durum==0)//timer başlatılır
            {
                button1.Text = "durdur";
                durum = 1;
                timer1.Start();
                button3.Enabled = true;
            }
            else if(durum==1)//timer durdurulur
            {
                button1.Text = "başlat";
                durum = 0;
                timer1.Stop();
                button3.Enabled = true;
            }
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(saniye==60)
            {
                dakika++;
                saniye = 0;
            }
            if(dakika==60)
            {
                saat++;
                saniye = 0;
                dakika = 0;
            }
            label1.Text = saat.ToString()+":"+dakika.ToString()+":"+ saniye.ToString();
            saniye++;
            
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            saat = 0;
            saniye = 0;
            dakika = 0;
            listBox1.Items.Clear();
            sayac = 1;
            label1.Text = saat.ToString() + ":" + dakika.ToString() + ":" + saniye.ToString();
            button3.Enabled = false;
            timer1.Stop();
            durum = 0;
            button1.Text = "başlat";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
                
                listBox1.Items.Add(sayac+". tur: "+ saat + ":" + dakika + ":" + saniye);
            sayac++;
            
        }

    }
}
