using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace desain_UI_car_wash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apakah Anda Ingin Melanjutkan Proses ini", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

           
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Mobil");
            comboBox1.Items.Add("Motor");
        }

      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            comboBox2.Items.Clear();

           
            if (comboBox1.SelectedItem.ToString() == "Mobil")
            {
                comboBox2.Items.Add("Cuci Manual (Rp 30.000 - Rp 60.000)");
                comboBox2.Items.Add("Cuci Hidrolik (Rp 50.000 - Rp 100.000)");
                comboBox2.Items.Add("Cuci Salju (Rp 50.000 - Rp 120.000)");
                comboBox2.Items.Add("Cuci Detailing (Rp 200.000 - Rp 1.000.000)");
                comboBox2.Items.Add("Cuci Steam (Rp 100.000 - Rp 200.000)");
                comboBox2.Items.Add("Cuci Premium (Rp 300.000 - Rp 2.000.000)");
                comboBox2.Items.Add("Cuci Express (Rp 20.000 - Rp 40.000)");
            }
            else if (comboBox2.SelectedItem.ToString() == "Motor")
            {
                comboBox2.Items.Add("Cuci Manual (Rp 10.000 - Rp 30.000)");
                comboBox2.Items.Add("Cuci Hidrolik (Rp 20.000 - Rp 40.000)");
                comboBox2.Items.Add("Cuci Salju (Rp 20.000 - Rp 40.000)");
                comboBox2.Items.Add("Cuci Detailing (Rp 50.000 - Rp 200.000)");
                comboBox2.Items.Add("Cuci Steam (Rp 30.000 - Rp 60.000)");
            }
        }

        private void txtNamaPelanggan_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
