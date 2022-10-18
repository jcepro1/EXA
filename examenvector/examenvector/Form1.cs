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

            int m = Int32.Parse(textBox1.Text);
            v1.ejercicio1(m);
            textBox5.Text = v1.Descargar();
        }

        private void pregunta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2 = new Vector();
            v3 = new Vector();
            int m, a, b;
            m = Int32.Parse(textBox1.Text);
            a = Int32.Parse(textBox2.Text);
            b = Int32.Parse(textBox3.Text);
            v1.ejercicio2(v2,v3,m, a, b);
            textBox5.Text = v2.Descargar();
            textBox6.Text = v3.Descargar();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
