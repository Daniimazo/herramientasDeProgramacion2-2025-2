using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wProyectoClinica.domain.model
{
    internal class MedicalInsurance
    {
        private string companyName;
        private ulong numberPolicy;
        private bool statusPolicy;
        private DateTime validityPolicy;

        public string CompanyName { get => companyName; set => companyName = value; }
        public ulong NumberPolicy { get => numberPolicy; set => numberPolicy = value; }
        public bool StatusPolicy { get => statusPolicy; set => statusPolicy = value; }
        public DateTime ValidityPolicy { get => validityPolicy; set => validityPolicy = value; }
    }
}
