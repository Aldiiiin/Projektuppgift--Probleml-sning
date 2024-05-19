using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prov_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double förstaSiffran = Convert.ToDouble(textBox1.Text);
                double andraSiffran = Convert.ToDouble(textBox2.Text);

                double andel = andraSiffran / förstaSiffran * 100;

                if (andel >= 90)
                {
                    MessageBox.Show("Bra jobbat! Du fick A.");
                }
                else if (andel >= 80)
                {
                    MessageBox.Show("Bra jobbat! Du fick B.");
                }
                else if (andel >= 70)
                {
                    MessageBox.Show("Bra jobbat! Du fick C.");
                }
                else if (andel >= 60)
                {
                    MessageBox.Show("Bra jobbat! Du fick D.");
                }
                else if (andel >= 50)
                {
                    MessageBox.Show("Bra jobbat! Du fick E.");
                }
                else
                {
                    MessageBox.Show("Du är tyvärr inte godkänd.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Felaktig inmatning. Ange giltiga numeriska värden.");
            }
        }
    }
}
        
    

