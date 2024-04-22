using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploExcepcion
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
                int Num1 = Convert.ToInt32(textBox1.Text);

                int resultado = Num1 / Convert.ToInt32(textBox2.Text);
            }
            catch (DivideByZeroException ex)
            {
                //throw new Exception("no puedes dividir entre cero");
                MessageBox.Show("no se puede dividir entre cero", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.Message);
            }
            finally 
            {
                MessageBox.Show("finaliza la excepcion");
            }
        }
    }
}
