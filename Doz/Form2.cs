using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || (radioButton1.Checked == false && radioButton2.Checked == false) || (radioButton3.Checked == false && radioButton4.Checked == false))
            {
                MessageBox.Show("برخی فیلدها مقداردهی نشده است", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else if (checkBox1.Checked == false)
                MessageBox.Show("شما ربات هستید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                MessageBox.Show("ثبت نام شما با موفقیت انجام شد", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 n = new Form1();
                n.Show();
                this.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.RightToLeftLayout = true;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ثبت نام";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Visible = true;
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Visible = false;
            timer2.Enabled = false;
            timer1.Enabled = true;
        }
    }
}
