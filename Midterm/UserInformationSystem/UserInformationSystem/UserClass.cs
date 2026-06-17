using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInformationSystem
{
    class UserClass
    {
        private int UserId;
        private String FirstName;
        private String MiddleName;
        private String LastName;
        private int Age;
        private String Address;
        private String Username;
        private String Password;

        public UserClass(int userId, String firstname, String middlename, String lastname, int age,
            String address, String username, String password)
        {
            this.UserId = userId;
            this.FirstName = firstname;
            this.MiddleName = middlename;
            this.LastName = lastname;
            this.Age = age;
            this.Address = address;
            this.Username = username;
            this.Password = password;

        }

        public void DisplayInfo()
        {
            MessageBox.Show("ID: " + UserId + "\nFirst Name: " + FirstName + "\nMiddle Name: " + MiddleName + "\nLastName: " + LastName
                + "\nAge: " + Age + "\nAddress: " + Address + "\nUsername: " + Username + "\nPassword: " + Password);
        }


        public int userId
        {
            get { return UserId; }
            set { UserId = value; }
        }

        public String firstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public String middleName
        {
            get { return MiddleName; }
            set { MiddleName = value; }
        }

        public String lastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }

        public String address
        {
            get { return Address; }
            set { Address = value; }
        }

        public String username
        {
            get { return Username; }
            set { Username = value; }
        }

        public String password
        {
            get { return Password; }
            set { Password = value; }
        }
    }
}
