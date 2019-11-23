using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kategori;
            int harga = 0;
            int harga2 = 0;
            int total = 0;
            int paket = 0;
            int snackdanminuman = 0;
            kategori = comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex == 1)
            {
                harga = 75000;
                harga2 = 35000;
                paket = comboBox2.SelectedIndex + 1;//Convert.ToInt(comboBox2.SelectedValue);
                snackdanminuman = comboBox3.SelectedIndex + 1;
                total = (harga * paket) + (harga2 * snackdanminuman);

            }
            else if (comboBox1.SelectedIndex == 0)
            {
                harga = 50000;
                harga2 = 20000;
                paket = comboBox2.SelectedIndex + 1;//Convert.ToInt(comboBox2.SelectedValue);
                snackdanminuman = comboBox3.SelectedIndex + 1;
                total = (harga * paket) + (harga2 * snackdanminuman);

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                harga = 100000;
                harga2 = 50000;
                paket = comboBox2.SelectedIndex + 1;//Convert.ToInt(comboBox2.SelectedValue);
                snackdanminuman = comboBox3.SelectedIndex + 1;
                total = (harga * paket) + (harga2 * snackdanminuman);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                harga = 125000;
                harga2 = 75000;
                paket = comboBox2.SelectedIndex + 1;//Convert.ToInt(comboBox2.SelectedValue);
                snackdanminuman = comboBox3.SelectedIndex + 1;
                total = (harga * paket) + (harga2 * snackdanminuman);
            }
            textBox2.Text = " " + total;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int daftarmenu;
            daftarmenu = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex == 1)
            {
                textBox4.Text = "1 Soft Drink (CocaCola/Fanta/Sprite)," + "\n2 Snack uk Sedang";
            }
            else if (listBox1.SelectedIndex == 0)
            {
                textBox4.Text = "1 Soft Drink (Fanta/Sprite)," + "\n 2 Snack uk Kecil";
            }
            else if (listBox1.SelectedIndex == 2)
            {
                textBox4.Text = "1 Soft Drink (Bebas Memilih)," + "\n 1 Syrup Orange," + "\n 2 Snack uk Besar";
            }
            else if (listBox1.SelectedIndex == 3)
            {
                textBox4.Text = "1 Soft Drink (Bebas Memilih)," + "\n 1 Syrup (Bebas Memilih)," + "\n 2 Snack uk Besar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
                textBox3.Text = String.Empty;
                textBox4.Text = String.Empty;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Terimakasih";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;

            progressBar1.Maximum = 200;
            progressBar1.Minimum = 0;

            for (i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;
            }
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terimakasih sudah berkunjung di Quest Karaoke" +
                "\nSelamat Menikmati" +
                "\n(Created by Maft.DU)");
        }
    }
}
