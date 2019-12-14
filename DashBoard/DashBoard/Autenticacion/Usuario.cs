using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNA.DashBoard.Autenticacion
{
    class Usuario
    {
        private string nombreUsuario;
        private string contrasena;

        public Usuario(string nom, string cont)
        {
            nombreUsuario = nom;
            contrasena = cont;
        }
        public string devolverUsuario()
        {
            return nombreUsuario;
        }

        public void autenticar()
        {

        }
    }
}
