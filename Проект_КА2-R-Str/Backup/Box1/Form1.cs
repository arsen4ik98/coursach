using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Box1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();         
        }
        private void button1_Click(object sender, EventArgs e)
        {      
            dGV1.Rows.Clear();
            Box.A = int.Parse(textBox1.Text);
            int q = int.Parse(textBox2.Text);
            Box.Q = int.Parse(textBox4.Text);
            for (int i = 0; i < q; i++)
            {
                dGV1.Rows.Add(Box.X.Next(q), Box.X.Next(2), Box.X.Next(q), Box.X.Next(2));
                dGV1.Rows[i].HeaderCell.Value = "q" + i.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            for (int i = 1; i <= Box.A; i++)
            {
               int a = Box.X.Next(2);
                    if (a == 0)
                    {
                        Box.V = (int)dGV1[1, Box.Q].Value;
                        Box.Q = (int)dGV1[0, Box.Q].Value;
                    }
                    else
                    {
                        Box.V = (int)dGV1[3, Box.Q].Value;
                        Box.Q = (int)dGV1[2, Box.Q].Value;
                    }
                    textBox1.Text = textBox1.Text + a.ToString();
                    textBox2.Text = textBox2.Text + Box.Q.ToString();
                    textBox3.Text = textBox3.Text + Box.V.ToString();
            }
        }

    }
}
