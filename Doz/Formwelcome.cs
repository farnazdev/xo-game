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
    public partial class Formwelcome : Form
    {
        Label r = new Label();
        public Formwelcome()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Width += 10;
            if (label1.Width >= this.ClientSize.Width)
            {
                timer1.Enabled = false;
                Form2 n = new Form2();
                n.Show();
                this.Hide();
            }
        }

        private void Formwelcome_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Formwelcome_MouseDown(object sender, MouseEventArgs e)
        {
            this.Controls.Remove(r);
            r.BackColor = Color.Transparent;
            r.Text = "Please wait";
            r.Location = e.Location;
            this.Controls.Add(r);
        }

        private void Formwelcome_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Help;
        }
    }
}
