using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wProyectoClinica.domain.model
{
    internal class Patient : Person
    {
        private string gender;
        public string Gender { get => gender; set => gender = value; }
    }
}
