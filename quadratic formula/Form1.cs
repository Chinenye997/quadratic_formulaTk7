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
            MessageBox.Show("Clicked!"); // Button to click
            

            try
            {
                // Parse inputs
                double a = double.Parse(tb_a.Text);
                double b = double.Parse(tb_b.Text);
                double c = double.Parse(tb_c.Text);

                // Check if a is zero
                if (a == 0)
                {
                    MessageBox.Show("Coefficient 'a' cannot be 0 for a quadratic equation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate discriminant
                double discriminant = Math.Pow(b, 2) - (4 * a * c);

                if (discriminant > 0)
                {
                    // Two distinct real roots
                    double ans1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double ans2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                    lb_Answer1.Text = ans1.ToString("n2");
                    lb_Answer2.Text = ans2.ToString("n2");
                }
                else if (discriminant == 0)
                {
                    // One real root (repeated)
                    double ans = -b / (2 * a);

                    lb_Answer1.Text = ans.ToString("n2");
                    lb_Answer2.Text = "Repeated root";
                }
                else
                {
                    // Complex roots
                    double realPart = -b / (2 * a);
                    double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);

                    lb_Answer1.Text = $"{realPart:n2} + {imaginaryPart:n2}i";
                    lb_Answer2.Text = $"{realPart:n2} - {imaginaryPart:n2}i";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for a, b, and c.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear input fields
            tb_a.Text = string.Empty;
            tb_b.Text = string.Empty;
            tb_c.Text = string.Empty;


            // Clear output labels
            lb_Answer1.Text = string.Empty;
            lb_Answer2.Text = string.Empty;
        }

        private void btnShowFormula_Click(object sender, EventArgs e)
        {

            // Check the current text of the button
            if (btnShowFormula.Text == "Show Formula")
            {
                // Change the text to display the formula
                btnShowFormula.Text = "x = (-b ± √(b² - 4ac)) / 2a";
            }
            else
            {
                // Change the text back to the original
                btnShowFormula.Text = "Show Formula";
            }


        }
    }
}

