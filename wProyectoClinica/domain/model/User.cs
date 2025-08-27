using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wProyectoClinica.domain.model
{
    internal class User : Person
    {
        private string rol;
        private string userName;
        private string password;

        public string Rol { get => rol; set => rol = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
