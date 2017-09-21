using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ka1
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
            
            KA.N = int.Parse(textBox3.Text);
            KA.Q = 1;
            Random x = new Random();
            for (int i = 0; i < KA.N; i++)
            {
                dGV1.Rows.Add(x.Next(KA.N), x.Next(2), x.Next(KA.N), x.Next(2));
                dGV1.Rows[i].HeaderCell.Value = "q" + i.ToString();
                dGV1.Rows[i].HeaderCell.Style.BackColor = Color.WhiteSmoke;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < KA.N; i++)
            {
                dGV1[1,i ].Style.BackColor = Color.White;
                dGV1[0, i].Style.BackColor = Color.White;
                dGV1[3, i].Style.BackColor = Color.White;
                dGV1[2, i].Style.BackColor = Color.White;
            }
            dGV1.Rows[KA.Q].HeaderCell.Style.BackColor = Color.WhiteSmoke;
            int a = int.Parse(textBox1.Text);
            if (a == 0)
            {
                KA.V = (int)dGV1[1, KA.Q].Value;
                dGV1[1, KA.Q].Style.BackColor = Color.LightBlue;
                dGV1[0, KA.Q].Style.BackColor = Color.LightBlue;
                KA.Q = (int)dGV1[0, KA.Q].Value;
            }
            else
            {
                KA.V = (int)dGV1[3, KA.Q].Value;
                dGV1[3, KA.Q].Style.BackColor = Color.LightBlue;
                dGV1[2, KA.Q].Style.BackColor = Color.LightBlue;
                KA.Q = (int)dGV1[2, KA.Q].Value;
            }
            textBox2.Text = KA.V.ToString();
            textBox3.Text = KA.Q.ToString();
            dGV1.Rows[KA.Q].HeaderCell.Style.BackColor =Color.LightPink;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
