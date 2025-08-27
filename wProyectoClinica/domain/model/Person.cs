using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wProyectoClinica.domain.model
{
    internal class Person
    {
        private ulong id;
        private string name;
        private string lastName;
        private int age;
        private string email;
        private ulong cellPhone;
        private DateTime birthday;
        private string address;

        public ulong Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
        public ulong CellPhone { get => cellPhone; set => cellPhone = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }
    }
}
