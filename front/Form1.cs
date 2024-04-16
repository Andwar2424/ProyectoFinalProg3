using acessoDato;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace front
{
    public partial class Form1 : Form
    {
        AcessoDatos acesso = AcessoDatos.getInstance();
        int valor;
        public Form1(int valor )
        {
            InitializeComponent();
            this.valor = valor;
            listBox1.DataSource = acesso.Select();


        }
        public Form1()
        {
            InitializeComponent();
            button4.Enabled = false;
            button5.Enabled = false;
            listBox1.DataSource = acesso.Select();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            

            agendaDTO agenda = new agendaDTO();

            agenda.Nombre = textBox1.Text;
            MessageBox.Show(textBox2.Text);
            agenda.cantidad =Int32.Parse( textBox2.Text);
            agenda.provedores = textBox3.Text;
      

            acesso.insert(agenda);
            listBox1.DataSource = acesso.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificar modificarU= new modificar();
            this.Hide();
            modificarU.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar(); 
            eliminar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            login lo = new login();
            lo.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
