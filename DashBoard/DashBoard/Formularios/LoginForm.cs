using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.DashBoard.Autenticacion;

namespace UNA.DashBoard.Formularios
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        internal Usuario Usuario { get; set; }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admi" && txtContraseña.Text == "1234")
            {

            }
            else
            {
                errorProviderUsuario.SetError(txtUsuario, "Este nombre de usuario no esta registrado");
            }

            if (txtUsuario.TextLength == 0)
            {
                errorProviderUsuario.SetError(txtUsuario, "No se ha ingresado ningun usuario");
            }
            if (txtContraseña.TextLength == 0)
            {
                errorProviderContrasena.SetError(txtContraseña, "No se ha ingresado ninguna contraseña");
            }
            //Usuario = new Usuario(txtUsuario.Text, txtContraseña.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
