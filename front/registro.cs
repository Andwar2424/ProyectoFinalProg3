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
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="" || textBox2.Text == "")
            {
                MessageBox.Show("username or password was emply");
            }
            else
            {
                AcessoDatos acesso = AcessoDatos.getInstance();

                createU ce = new createU();
                ce.username=textBox1.Text;
                ce.password = textBox2.Text;

                acesso.insertU(ce);

                this.Hide();
                Form1 a = new Form1();
                a.Show();
            }
        }
    }
}
