using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios;

namespace FormMain
{
    public partial class Form1 : Form
    {
        public Usuario usuario;
        public static IngresoUsuario operador;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.usuario = new Usuario(this.textBox1.Text.ToString(), this.textBox2.Text.ToString());

            if(Form1.operador == this.usuario)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario Inexistente");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario usUno = new Usuario("christignino", "100727");
            Usuario usDos = new Usuario("robert", "01234");
            Usuario usTres = new Usuario("guardian", "espectro");
        }
    }
}
