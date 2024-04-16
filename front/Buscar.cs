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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AcessoDatos acesso = AcessoDatos.getInstance();
            listBox1.DataSource = acesso.Select(nombres: textBox1.Text);


        }

        private void Buscar_Load(object sender, EventArgs e)
        {

        }
    }
}
