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
    public partial class FormLogin : Form
    {
        public Usuario usuario;
        public static IngresoUsuario usuarioExistente;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario usuario1 = new Usuario("christignino", "100727");
            Usuario usuario2 = new Usuario("robert", "01234");
            Usuario usuario3 = new Usuario("guardian", "espectro");
            Usuario usuario4 = new Usuario("c", "c");

            usuarioExistente = new IngresoUsuario();
            usuarioExistente += usuario1;
            usuarioExistente += usuario2;
            usuarioExistente += usuario3;
            usuarioExistente += usuario4;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            this.usuario = new Usuario(this.textBox1.Text.ToString(), this.textBox2.Text.ToString());

            if(FormLogin.usuarioExistente == this.usuario)
            {
                this.DialogResult = DialogResult.OK;
                form.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Este usuario no existe");
            }
        }
    }
}
