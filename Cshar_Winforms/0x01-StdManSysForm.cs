using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management
{
    public partial class Form1 : Form
    {
        string path;
        string data;
        string id;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str_init();
                using (StreamWriter writer = new StreamWriter(path, append: true))
                {
                    writer.WriteLine(data);
                }
                data = null;
                MessageBox.Show("Student added successfully !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            path = textBox2.Text;
            /*   textBox1.Text = "";
               textBox3.Text = "";
               textBox4.Text = "";
               textBox5.Text = "";
               textBox6.Text = "";
               textBox7.Text = "";
               textBox8.Text = "";
               --->Big O(1) 
             */
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
                //Big O(n)
            }

        }

        void str_init()
        {
            data = textBox1.Text;
            data += "-";
            data += textBox3.Text;
            data += "-";
            data += textBox4.Text;
            data += "-";
            data += textBox5.Text;
            data += "-";
            data += textBox6.Text;
            data += "-";
            data += textBox7.Text;
            data += "-";
            data += textBox8.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string line;
            string name;
            string age;
            string ssn;
            string address;
            string number;
            string mail;
            using (StreamReader read = new StreamReader(path))
            {
                while ((line = read.ReadLine()) != null)
                {
                    string[] info = line.Split('-');
                    if (info[0] == textBox21.Text)
                    {
                        name = info[0];
                        ssn = info[1];
                        id = info[2];
                        age = info[3];
                        address = info[4];
                        mail = info[5];
                        number = info[6];

                        textBox22.Text = ssn;
                        textBox23.Text = id;
                        textBox24.Text = number;
                        textBox22.Text = name;
                        textBox25.Text = age;
                        textBox26.Text = address;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
             {
               e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')   // هنا انا محدد انه ميدخلش الا كلمات و مسافه   
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    textBox4.Focus(); 
                }
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "") 
                {
                    textBox8.Focus();
                }
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "") 
                {
                    textBox3.Focus();
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    textBox5.Focus();  
                }
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "") 
                {
                    textBox6.Focus();  
                }
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "") 
                {
                    button1.Focus(); 
                }
            }
        }
    }

 }
