using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wProyectoClinica.domain.model
{
    internal class EmergencyContact:Person
    {
        private string relation;

        public string Relation { get => relation; set => relation = value; }
    }
}
