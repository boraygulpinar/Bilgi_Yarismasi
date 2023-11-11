using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void buttonB_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            label3.Text = buttonB.Text;
            if(label2.Text == label3.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            label3.Text = buttonC.Text;
            if (label2.Text == label3.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            label3.Text = buttonD.Text;
            if (label2.Text == label3.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            label3.Text = buttonA.Text;
            if(label2.Text == label3.Text)
            {
                dogru++;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible=false;
            button5.Enabled = false;
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;

            soruno++;
            labelSoruNo.Text = soruno.ToString();

            if(soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet Kaç Yılında Kurulmuştur ?";
                buttonA.Text = "1920";
                buttonB.Text = "1921";
                buttonC.Text = "1922";
                buttonD.Text = "1923";
                label2.Text = "1923";

            }
            if(soruno == 2)
            {
                richTextBox1.Text = "Çay En Çok Hangi İlimizde Üretilir ?";
                buttonA.Text = "Manisa";
                buttonB.Text = "Diyarbakır";
                buttonC.Text = "Rize";
                buttonD.Text = "Eskişehir";
                label2.Text = "Rize";
            }
            if(soruno == 3)
            {
                richTextBox1.Text = "5 Sayısının Küpü Nedir ?";
                buttonA.Text = "125";
                buttonB.Text = "75";
                buttonC.Text = "25";
                buttonD.Text = "5";
                label2.Text = "125";
                button5.Text = "SONUÇLAR";




            }
            if (soruno == 4)
            {
                labelSoruNo.Visible = false;
                button5.Enabled = false;
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                MessageBox.Show("Doğru:" + labelDogru.Text + "\n" + "Yanlış:" + labelYanlis.Text);
            }
        }
    }
}
