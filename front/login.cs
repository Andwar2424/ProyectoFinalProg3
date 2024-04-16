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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.TransparencyKey= Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AcessoDatos acesso = AcessoDatos.getInstance();

            string nombre = textBox1.Text;
            string pas= textBox2.Text;

            int valor = acesso.validar(nombre,pas);
            if(valor == 1)
            {
                Form1 hola = new Form1(1);
                hola.Show();
                this.Hide();
            }
            else
            {
                Form1 hola = new Form1();
                hola.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            registro re = new registro();
            re.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
