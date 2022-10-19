using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenvector
{
    public partial class Form1 : Form
    {
        Vector v1,v2,v3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
          
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n1, a, b;

            n1 = Int32.Parse(textBox1.Text);
            a = Int32.Parse(textBox2.Text);
            b = Int32.Parse(textBox3.Text);

            v1.CargarRamdom(n1, a, b);
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.Descargar();
        }

        private void pregunta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            textBox6.Text = v1.examen1(v2);
        }

        private void pregunta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Int32.Parse(textBox2.Text);
            b = Int32.Parse(textBox3.Text);
            v1.examen2(a, b);
            textBox5.Text = v1.Descargar();
        }

        private void cargarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            int n1, a, b;

            n1 = Int32.Parse(textBox1.Text);
            a = Int32.Parse(textBox2.Text);
            b = Int32.Parse(textBox3.Text);

            v2.CargarRamdom(n1, a, b);
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.Descargar();
        }
    }
}
