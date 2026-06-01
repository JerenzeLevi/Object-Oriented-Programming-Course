using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulatedClass_Giamat
{
    class UserClass
    {
        private String Name;
        private int Age;
        private String Gmail;
        private String Address;
        private String ContactNumber;

        public UserClass (String name, int age, String gmail, String address, String contactNumber)
        {
            this.Name = name;
            this.Age = age;
            this.Gmail = gmail;
            this.Address = address;
            this.ContactNumber = contactNumber;
        }
        public String name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }

        public String gmail
        {
            get { return Gmail; }
            set { Gmail = value; }
        }

        public String address
        {
            get { return Address; }
            set { Address = value; }
        }

        public String  contact
        {
            get { return ContactNumber; }
            set { ContactNumber = value; }
        }
    }
}
