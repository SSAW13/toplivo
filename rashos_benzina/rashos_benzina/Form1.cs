using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rashos_benzina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float p = Convert.ToInt32(textBox1.Text);
            float r = Convert.ToInt32(textBox2.Text);
            float S = Convert.ToInt32(textBox3.Text);

            float x = r/100;//кол-во литров на 1км
            float xp = x * p;//цена за 1 км
            float rez = xp * S;//цена за весь путь

            label5.Text = x + " кол-во литров топлива на 1км";
            label6.Text = xp + " стоимость 1км";
            label7.Text = rez + " цена за весь путь";
        }

    }
}
