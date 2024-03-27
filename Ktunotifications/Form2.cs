using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ktunotifications
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
            if(textBox1.Text== "Enter your name")
            {
                textBox1.Text = "";
            }
            
            textBox1.ForeColor = Color.SteelBlue;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text== "")
            {
                textBox1.Text = "Enter your name";
                textBox1.ForeColor = SystemColors.InactiveCaption;
            }
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter a username")
            {
                textBox2.Text = "";
            }
            textBox2.ForeColor = Color.SteelBlue;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter a username";
                textBox2.ForeColor =SystemColors.InactiveCaption;
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Enter your email address")
            {
                textBox3.Text = "";
            }
            textBox3.ForeColor = Color.SteelBlue;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Enter your email address";
                textBox3.ForeColor = SystemColors.InactiveCaption;
            }
                  
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Enter your password")
            {
                textBox4.Text = "";   
                textBox4.UseSystemPasswordChar = true;
            }
            textBox4.ForeColor = Color.SteelBlue;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Enter your password";
                textBox4.UseSystemPasswordChar = false;
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;

                textBox4.ForeColor = SystemColors.InactiveCaption;
            }
            
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Enter your password again")
            {
                textBox5.Text = "";
                textBox5.UseSystemPasswordChar = true;
            }
            textBox5.ForeColor = Color.SteelBlue;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Enter your password again";
                pictureBox3.Visible = true;
                pictureBox5.Visible = false;
                textBox5.UseSystemPasswordChar = false;
                textBox5.ForeColor = SystemColors.InactiveCaption;
            }      
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            login frm1 = new login();
            frm1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
            textBox4.UseSystemPasswordChar = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox4.Visible = false;
            if (textBox4.Text == "Enter your password")
            {
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox4.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox5.Visible = true;
            textBox5.UseSystemPasswordChar = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox5.Visible = false;
            if (textBox5.Text == "Enter your password again")
            {
                textBox5.UseSystemPasswordChar = false;
            }
            else
            {
                textBox5.UseSystemPasswordChar = true;
            }
        }
    }
}
