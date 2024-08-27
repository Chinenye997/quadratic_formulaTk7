using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quadratic_formula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, ans1, ans2;

            a = double.Parse(tb_a.Text);
            b = double.Parse(tb_b.Text);
            c = double.Parse(tb_c.Text);

            ans1 = (-1 * b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            ans2 = (-1 * b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            lb_Answer1.Text = ans1.ToString("n2");
            lb_Answer2.Text = ans2.ToString("n2");

        }
    }
}
