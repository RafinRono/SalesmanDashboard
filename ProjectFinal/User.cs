using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinal
{
    public class User
    {
        private string id;
        private string name;
        private string password;
        private string phone;
        private string email;
        private string address;
        private string role;
        private string joiningDate;
        private double salary;

        internal string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        internal string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        internal string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        internal string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        internal string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        internal string JoiningDate
        {
            get { return this.joiningDate; }
            set { this.joiningDate = value; }
        }

        internal double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public User(string id, string name, string password, string phone, string email, string address, string role)
        {
            this.Id = id;
            this.Name = name;
            this.Password = password;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.Role = role;
        }
    }
}
