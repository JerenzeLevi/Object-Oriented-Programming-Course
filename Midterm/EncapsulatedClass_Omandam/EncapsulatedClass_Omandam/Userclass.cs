using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulatedClass_Omandam
{
    class Userclass
    {
        private String Fullname;
        private int Age;
        private String Nationality;
        private String CivilStatus;
        private String BirthDate;

        public Userclass(String fullname, int age, String nationality, String civilStatus, String birthDate)
        {
            this.Fullname = fullname;
            this.Age = age;
            this.Nationality = nationality;
            this.CivilStatus = civilStatus;
            this.BirthDate = birthDate;
        }

        public String fullname
        {
            get { return Fullname; }
            set { Fullname = value; }
        }

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }

        public String natonality
        {
            get { return Nationality; }
            set { Nationality = value; }
        }

        public String civilStatus
        {
            get { return CivilStatus; }
            set { CivilStatus = value; }
        }

        public String birthDate
        {
            get { return BirthDate; }
            set { BirthDate = value; }
        }

    }


}
