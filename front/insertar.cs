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
    public partial class insertar : Form
    {
        public insertar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AcessoDatos acesso = AcessoDatos.getInstance();

            agendaDTO agenda = new agendaDTO();

            agenda.Nombre = textBox1.Text;
  

            acesso.insert(agenda);
        }

        private void insertar_Load(object sender, EventArgs e)
        {

        }
    }
}
