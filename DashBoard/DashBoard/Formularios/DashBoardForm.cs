using System;
using System.Windows.Forms;
using UNA.DashBoard.Autenticacion;

namespace UNA.DashBoard.Formularios
{
    public partial class DashBoardForm : Form
    {
        private Usuario usuario;
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            
            do
            {
                LoginForm login = new LoginForm();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                {

                    usuario = login.Usuario;
                }
                else
                {
                    login.Close();
                }
            } while (MessageBox.Show("Desea autenticarse?", "Atencion", MessageBoxButtons.YesNo) == DialogResult.Yes);

            Close();




            //Usuario admin = new Usuario("admin", "1234");
        }
    }
}
