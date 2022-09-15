using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoraherencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suma osuma = new Suma(); // Creacion de objeto.
            /* Asignando a los atributos los valores dados en los textBox mediante las propiedades set y get
            para utilizar el metodo sobrecargado de operar (el que no recibe parametros).*/
            osuma.Valor1 = double.Parse(textBox1.Text);
            osuma.Valor2 = double.Parse(textBox2.Text);
            textBox3.Text = osuma.operar().ToString();

            // Metodo que recibe parametros.
            textBox3.Text = osuma.operar(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resta oresta = new Resta(); // Creacion de objeto.
            /* Asignando a los atributos los valores dados en los textBox mediante las propiedades set y get
            para utilizar el metodo sobrecargado de operar (el que no recibe parametros).*/
            oresta.Valor1 = double.Parse(textBox1.Text);
            oresta.Valor2 = double.Parse(textBox2.Text);
            textBox3.Text = oresta.operar().ToString();

            // Metodo que recibe parametros.
            textBox3.Text = oresta.operar(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Multiplicar omul = new Multiplicar(); // Creacion de objeto.
            /* Asignando a los atributos los valores dados en los textBox mediante las propiedades set y get
            para utilizar el metodo sobrecargado de operar (el que no recibe parametros).*/
            omul.Valor1 = double.Parse(textBox1.Text);
            omul.Valor2 = double.Parse(textBox2.Text);
            textBox3.Text = omul.operar().ToString();

            // Metodo que recibe parametros.
            textBox3.Text = omul.operar(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dividir odiv = new Dividir(); // Creacion de objeto.
            /* Asignando a los atributos los valores dados en los textBox mediante las propiedades set y get
            para utilizar el metodo sobrecargado de operar (el que no recibe parametros).*/
            odiv.Valor1 = double.Parse(textBox1.Text);
            odiv.Valor2 = double.Parse(textBox2.Text);
            textBox3.Text = odiv.operar().ToString();

            // Metodo que recibe parametros.
            textBox3.Text = odiv.operar(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
