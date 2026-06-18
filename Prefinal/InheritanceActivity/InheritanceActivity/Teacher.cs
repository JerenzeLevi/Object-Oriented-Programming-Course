using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceActivity
{
    class Teacher : User
    {
        public string Subject { get; set; }

        public override string GetRole()
        {
            return "Teacher";
        }
    }
}
