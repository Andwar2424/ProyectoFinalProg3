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
    public partial class modificar : Form
    {
        AcessoDatos acesso = AcessoDatos.getInstance();
        public modificar()
        {
            InitializeComponent();
            

            listBox1.DataSource = acesso.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            agendaDTO agenda = new agendaDTO();

            agenda.id = Convert.ToInt32(textBox8.Text);

            agenda.Nombre = textBox1.Text;

            agenda.cantidad =Int32.Parse( textBox2.Text);

            agenda.provedores = textBox3.Text;

            acesso.update(agenda);
            listBox1.DataSource = acesso.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            
            this.Hide();
            form.Show();
        }
    }
}
