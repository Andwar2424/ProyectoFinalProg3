using acessoDato;
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
    public partial class Eliminar : Form
    {
        AcessoDatos acesso = AcessoDatos.getInstance();
       
        public Eliminar()
        {
            InitializeComponent();
            listBox1.DataSource = acesso.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            acesso.delete(Convert.ToInt32(textBox1.Text));
            listBox1.DataSource = acesso.Select();

        }

        private void Eliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
