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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = false;
            btnz.Enabled = false;
            btnd.Enabled = false;
            btnp.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((button6.Text == "x" && button3.Text == "x" && button9.Text == "x") ||
                (button1.Text == "x" && button3.Text == "x" && button7.Text == "x") ||
                (button1.Text == "x" && button4.Text == "x" && button6.Text == "x") ||
                (button2.Text == "x" && button3.Text == "x" && button5.Text == "x") ||
                (button9.Text == "x" && button8.Text == "x" && button7.Text == "x") ||
                (button1.Text == "x" && button2.Text == "x" && button9.Text == "x") ||
                (button4.Text == "x" && button3.Text == "x" && button8.Text == "x") ||
                (button6.Text == "x" && button5.Text == "x" && button7.Text == "x"))
            {
                button12.Text = "برنده شد x";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button12.Enabled = false;
                btnz.Enabled = false;
                btnd.Enabled = false;
            }
            else if ((button6.Text == "o" && button3.Text == "o" && button9.Text == "o") ||
                (button1.Text == "o" && button3.Text == "o" && button7.Text == "o") ||
                (button1.Text == "o" && button4.Text == "o" && button6.Text == "o") ||
                (button2.Text == "o" && button3.Text == "o" && button5.Text == "o") ||
                (button9.Text == "o" && button8.Text == "o" && button7.Text == "o") ||
                (button1.Text == "o" && button2.Text == "o" && button9.Text == "o") ||
                (button4.Text == "o" && button3.Text == "o" && button8.Text == "o") ||
                (button6.Text == "o" && button5.Text == "o" && button7.Text == "o"))
            {
                button12.Text = "برنده شد o";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button12.Enabled = false;
                btnz.Enabled = false;
                btnd.Enabled = false;
            }
            else
            {
                button12.Text = "ابتدا بازی کنید";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button12.Enabled = false;
                btnz.Enabled = false;
                btnd.Enabled = false;
            }
        }

        private void btnz_Click(object sender, EventArgs e)
        {
            btnd.Enabled = false;
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btnz.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (btnd.Enabled == true)
            {
                btnd.Enabled = false;
                btnz.Enabled = true;
            }
            else if (btnz.Enabled == true)
            {
                btnz.Enabled = false;
                btnd.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnz.Enabled == true)
                button1.Text = "x";
            else if (btnd.Enabled == true)
                button1.Text = "o";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (btnz.Enabled == true)
                button4.Text = "x";
            else if (btnd.Enabled == true)
                button4.Text = "o";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (btnz.Enabled == true)
                button6.Text = "x";
            else if (btnd.Enabled == true)
                button6.Text = "o";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnz.Enabled == true)
                button2.Text = "x";
            else if (btnd.Enabled == true)
                button2.Text = "o";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnz.Enabled == true)
                button3.Text = "x";
            else if (btnd.Enabled == true)
                button3.Text = "o";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (btnz.Enabled == true)
                button5.Text = "x";
            else if (btnd.Enabled == true)
                button5.Text = "o";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (btnz.Enabled == true)
                button9.Text = "x";
            else if (btnd.Enabled == true)
                button9.Text = "o";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (btnz.Enabled == true)
                button8.Text = "x";
            else if (btnd.Enabled == true)
                button8.Text = "o";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (btnz.Enabled == true)
                button7.Text = "x";
            else if (btnd.Enabled == true)
                button7.Text = "o";
        }

        private void btnsh_Click(object sender, EventArgs e)
        {
            btnsh.Text = "شروع مجدد";
            button11.Enabled = true;
            button1.Enabled = true;
            button1.Text = "";
            button2.Enabled = true;
            button2.Text = "";
            button3.Enabled = true;
            button3.Text = "";
            button4.Enabled = true;
            button4.Text = "";
            button5.Enabled = true;
            button5.Text = "";
            button6.Enabled = true;
            button6.Text = "";
            button7.Enabled = true;
            button7.Text = "";
            button8.Enabled = true;
            button8.Text = "";
            button9.Enabled = true;
            button9.Text = "";
            button10.Enabled = true;
            button12.Enabled = true;
            button12.Text = "بعد از کامل شدن سه کارکتر اینجا کلیک کنید";
            btnz.Enabled = true;
            btnd.Enabled = true;
            btnp.Enabled = true;
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
        }
    }
}
